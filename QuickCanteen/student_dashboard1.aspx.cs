using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickCanteen
{
    public partial class student_dashboard1 : System.Web.UI.Page
    {
        static int sum = 0;        
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!(Session["logged_in"].Equals(true) && Session["role"].Equals("student")))
            {
                Response.Redirect("~/login.aspx");

            }
            
            Label2.Text = "";

            if (!IsPostBack)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            canteen_master sel_canteen = (from canteen in db.canteen_masters where canteen.canteen_name.Equals(DropDownList1.SelectedItem.Text) select canteen).FirstOrDefault();
            int can_id = sel_canteen.canteen_id;
            GridView1.DataSource = from food_item in db.food_masters join menu in db.menu_masters on food_item.food_item_id 
                                   equals menu.food_item_id where menu.canteen_id == can_id
                                   select new { food_item.name, menu.qty, menu.rate };
            GridView1.DataBind();
            Session["can_id"] = can_id;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            List<string> can_list = (from canteen in db.canteen_masters
                            where DateTime.Now.TimeOfDay > (TimeSpan)canteen.open_time && DateTime.Now.TimeOfDay < (TimeSpan)canteen.close_time
                            select canteen.canteen_name).ToList();
            if (can_list.Count == 0)
            {
                Label5.Text = "No canteens are open at this time";
            }
            else
            {
                DropDownList1.DataSource = can_list;
                DropDownList1.DataBind();
                DropDownList1.SelectedIndex = 0;
                DropDownList1_SelectedIndexChanged(sender, e);
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = false;
                Panel4.Visible = false;
            }            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string name = row.Cells[1].Text;
            Label1.Text = name;
        }
        

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (((List<FoodCartItem>)Session["cart_obj"]).Exists(food_item => food_item.name.Equals(Label1.Text)) == false)
            {
                ((List<FoodCartItem>)Session["cart_obj"]).Add(new FoodCartItem(Label1.Text, Int32.Parse(TextBox1.Text)));
            }
            else
            {
                int index = ((List<FoodCartItem>)Session["cart_obj"]).FindIndex(food_item => food_item.name.Equals(Label1.Text));
                ((List<FoodCartItem>)Session["cart_obj"])[index].qty += Int32.Parse(TextBox1.Text);
            }
            GridView2.DataSource = (List<FoodCartItem>)Session["cart_obj"];
            GridView2.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            food_master sel_food = db.food_masters.Single(food_master => food_master.name.Equals(Label1.Text));
            int sel_food_id = sel_food.food_item_id;
            menu_master menu = (from sel_menu in db.menu_masters
                                where sel_menu.canteen_id == (int)Session["can_id"] &&
                                sel_menu.food_item_id == sel_food_id
                                select sel_menu).FirstOrDefault();
            if (Int32.Parse(TextBox1.Text) > menu.qty)
            {
                Label2.Text = "Reduce your quantity or select a new food item";
            }
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow gvrow = GridView2.Rows[e.RowIndex];
            string food_delete = gvrow.Cells[1].Text;
            int del_index = ((List<FoodCartItem>)Session["cart_obj"]).FindIndex(cartitem => cartitem.name.Equals(food_delete));            
            ((List<FoodCartItem>)Session["cart_obj"]).RemoveAt(del_index);            
            GridView2.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            int price = 0, tmp_sum = 0, rate;
            foreach (FoodCartItem cartitem in (List<FoodCartItem>)Session["cart_obj"])
            {
                foreach(GridViewRow gvrow in GridView1.Rows)
                {
                    if(gvrow.Cells[1].Text.Equals(cartitem.name))
                    {
                        rate = Int32.Parse(gvrow.Cells[3].Text);
                        price = cartitem.qty * rate;
                        break;
                    }
                }                
                tmp_sum += price;
            }
            Label3.Visible = true;
            Session["tot_amt"] = tmp_sum;
            Label3.Text = "Total Amount:" + tmp_sum.ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int rate;
            var db = new QCDBMLDataContext();
            int pending_order = db.order_headers.Count(order_header => order_header.canteen_id == (int)Session["can_id"] && order_header.status == "placed");
            canteen_master canteen = db.canteen_masters.Single(canteen_master => canteen_master.canteen_id == (int)Session["can_id"]);
            if(canteen.order_limit <= pending_order)
            {
                Label4.Text = "Canteen is overcrowded. Please order after a few minutes";
            }
            else
            {
                student_master student = db.student_masters.Single(student_master => student_master.id == (int)Session["id"]);
                long stu_wallet = (long)student.wallet;
                if(((int)Session["tot_amt"]) > stu_wallet)
                {
                    Label4.Text = "You dont have enough money in your wallet";
                }
                else
                {
                    student.wallet -= (int)Session["tot_amt"];
                    db.SubmitChanges();
                    canteen_master sel_canteen = db.canteen_masters.Single(canteen_master=> canteen_master.canteen_id == (int)Session["can_id"]);
                    sel_canteen.wallet += (int)Session["tot_amt"];
                    db.SubmitChanges();
                    order_header neworder = new order_header();
                    neworder.stu_id = (int)Session["id"];
                    neworder.canteen_id = (int)Session["can_id"];
                    neworder.order_date = DateTime.Now;
                    DateTime temp_date = (DateTime)neworder.order_date;                    
                    neworder.amount = (int)Session["tot_amt"];
                    neworder.status = "placed";
                    db.order_headers.InsertOnSubmit(neworder);
                    db.SubmitChanges();
                    order_header oh = db.order_headers.Single(order_header => order_header.order_date.Equals(temp_date));
                    int oid = oh.order_id;
                    foreach (GridViewRow gv2row in GridView2.Rows)
                    {
                        order_detail neworderdet = new order_detail();
                        neworderdet.order_id = oid;
                        food_master sel_food = db.food_masters.Single(food_master => food_master.name.Equals(gv2row.Cells[1].Text));
                        int sel_food_id = sel_food.food_item_id;
                        neworderdet.food_item_id = sel_food_id;
                        foreach (GridViewRow gvrow in GridView1.Rows)
                        {                            
                            if (gvrow.Cells[1].Text.Equals(gv2row.Cells[1].Text))
                            {
                                rate = Int32.Parse(gvrow.Cells[3].Text);
                                neworderdet.rate = rate;
                                neworderdet.qty = Int32.Parse(gv2row.Cells[2].Text);
                                break;
                            }
                        }
                        db.order_details.InsertOnSubmit(neworderdet);
                        menu_master menu = db.menu_masters.Single(menu_master => menu_master.canteen_id == neworder.canteen_id && menu_master.food_item_id == neworderdet.food_item_id);
                        menu.qty -= neworderdet.qty;
                        db.SubmitChanges();
                    }                                                            
                }
            }
            DropDownList1_SelectedIndexChanged(sender, e);
        }
        protected void Button7_Click(object sender, EventArgs e)
        {            
            var db = new QCDBMLDataContext();
            canteen_master canteen = db.canteen_masters.Single(canteen_master => canteen_master.canteen_name.Equals(DropDownList2.SelectedValue));
            double ratings = (double)canteen.rating;
            long fb_count = (long)canteen.feedback_count;
            int x = Int32.Parse(DropDownList3.SelectedValue);
            ratings = ((ratings * fb_count) + x) / (fb_count + 1);
            fb_count = fb_count + 1;
            canteen.rating = (decimal)ratings;
            canteen.feedback_count = fb_count;
            db.SubmitChanges();       
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel3.Visible = true;
            Panel2.Visible = false;
            Panel4.Visible = false;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = true;
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rows;
            int ord_id = Int32.Parse(GridView3.SelectedRow.Cells[2].Text);
            string can_select_sql = "SELECT canteen_id FROM order_header WHERE order_id = @o_id";
            SqlConnection con = (SqlConnection)Application["conobj"];
            SqlCommand can_select = new SqlCommand(can_select_sql, con);
            can_select.Parameters.AddWithValue("o_id", ord_id);
            SqlDataAdapter adapter = new SqlDataAdapter(can_select);
            DataSet dsCan = new DataSet();
            try
            {
                con.Open();
                rows = adapter.Fill(dsCan, "can_id");
                con.Close();
                int can_id = Convert.ToInt32(dsCan.Tables["can_id"].Rows[0]["canteen_id"]);

                can_select.CommandText = "insert into canteen_notification_master(canteen_id,message) values (@c_id,@mess)";
                can_select.Parameters.AddWithValue("c_id", can_id);
                can_select.Parameters.AddWithValue("mess", "Cancellation request for order ID: " + ord_id.ToString());
                con.Open();
                can_select.ExecuteNonQuery();
                con.Close();
                can_select.CommandText = "update order_header set status = 'can_request' where order_id = @ord_id";
                can_select.Parameters.AddWithValue("ord_id", ord_id);
                con.Open();
                can_select.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
            GridView3.DataBind();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DropDownList4.Visible = true;
            GridView4.Visible = true;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View_Stu_Profile.aspx");
        }
    }
}