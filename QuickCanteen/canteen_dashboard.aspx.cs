using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuickCanteen
{
    
    public partial class canteen_dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Session["logged_in"].Equals(true) && Session["role"].Equals("manager")))
            { 
                Response.Redirect("~/login.aspx");
            }
            if(!IsPostBack)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;
            Panel4.Visible = false;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {                        
            int rows;
            string food_name = GridView1.Rows[e.NewEditIndex].Cells[1].Text;
            string food_select_sql = "SELECT food_item_id FROM food_master WHERE name = @fd_name;";
            SqlConnection con = (SqlConnection)Application["conobj"];
            SqlCommand food_select = new SqlCommand(food_select_sql, con);
            food_select.Parameters.AddWithValue("fd_name", food_name);
            SqlDataAdapter adapter = new SqlDataAdapter(food_select);
            DataSet dsFood = new DataSet();
            try
            {
                con.Open();
                rows = adapter.Fill(dsFood, "food");
                con.Close();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
            Session["food_id"] = dsFood.Tables["food"].Rows[0][0];
            /*foreach (DataRow row in dsFood.Tables["food"].Rows)
            {
                Session["food_id"] = Int32.Parse(row["food_item_id"].ToString());
            }*/
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.SelectedRow;
            //string new_food_name = row.Cells[0].Text;
            int inserted;
            SqlConnection con = (SqlConnection)Application["conobj"];
            string ins_sql = "INSERT INTO menu_master (canteen_id, food_item_id) VALUES (@c_id, @f_id);";
            SqlCommand cmd = new SqlCommand(ins_sql, con);
            cmd.Parameters.AddWithValue("c_id", Int32.Parse(Session["id"].ToString()));
            //Response.Write(row.Cells[0].Text);
            cmd.Parameters.AddWithValue("f_id", Int32.Parse(row.Cells[1].Text));
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int inserted;
            SqlConnection con = (SqlConnection)Application["conobj"];
            string ins_sql = "INSERT INTO food_master (name) VALUES (@f_name);";
            SqlCommand cmd = new SqlCommand(ins_sql, con);            
            cmd.Parameters.AddWithValue("f_name", TextBox1.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
            GridView2.DataBind();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {            
            DetailsView1.DataBind();
            DetailsView1.Visible = true;
        
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView3.Rows[e.RowIndex];
            int update_order_id = Int32.Parse(row.Cells[1].Text);            
            SqlConnection con = (SqlConnection)Application["conobj"];
            string upd_sql = "UPDATE order_header SET status = @new_status WHERE order_id = @o_id;";
            SqlCommand cmd = new SqlCommand(upd_sql, con);
            cmd.Parameters.AddWithValue("new_status", "prepared");
            cmd.Parameters.AddWithValue("o_id", update_order_id);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
            
            cmd.CommandText = "INSERT INTO student_notification_master(student_id,message) VALUES (@stu_id, 'prepared')";
            cmd.Parameters.AddWithValue("stu_id", Int32.Parse(GridView3.SelectedRow.Cells[2].Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridView3.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rows;
            string food_name = GridView1.Rows[e.RowIndex].Cells[1].Text;
            string food_select_sql = "SELECT food_item_id FROM food_master WHERE name = @fd_name;";
            SqlConnection con = (SqlConnection)Application["conobj"];
            SqlCommand food_select = new SqlCommand(food_select_sql, con);
            food_select.Parameters.AddWithValue("fd_name", food_name);
            SqlDataAdapter adapter = new SqlDataAdapter(food_select);
            DataSet dsFood = new DataSet();
            try
            {
                con.Open();
                rows = adapter.Fill(dsFood, "food");
                con.Close();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
            Session["food_id"] = dsFood.Tables["food"].Rows[0][0];
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string update_sql = "UPDATE order_header SET status = 'can_app' WHERE order_id = @o_id;";
            SqlConnection con = (SqlConnection)Application["conobj"];
            SqlCommand cmd = new SqlCommand(update_sql, con);
            try
            {
                foreach (GridViewRow gvrow in GridView4.Rows)
                {
                    var chkbox = gvrow.FindControl("CheckBox1") as CheckBox;
                    if(chkbox.Checked)
                    {
                        cmd.Parameters.AddWithValue("o_id", Int32.Parse(gvrow.Cells[1].Text));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "UPDATE canteen_master SET wallet = wallet - @amt WHERE canteen_id = @c_id;";
                        cmd.Parameters.AddWithValue("c_id", (int)Session["id"]);
                        cmd.Parameters.AddWithValue("amt", Double.Parse(gvrow.Cells[4].Text));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "UPDATE student_master SET wallet = wallet + @amt WHERE id = @s_id;";
                        cmd.Parameters.AddWithValue("s_id", Int32.Parse(gvrow.Cells[2].Text));
                        cmd.Parameters.AddWithValue("amt", Double.Parse(gvrow.Cells[4].Text));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Parameters.Clear();
                    }
                }
                GridView4.DataBind();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string update_sql = "UPDATE order_header SET status = 'can_deny' WHERE order_id = @OID;";
            SqlConnection con = (SqlConnection)Application["conobj"];
            SqlCommand cmd = new SqlCommand(update_sql, con);
            try
            {
                foreach (GridViewRow gvrow in GridView4.Rows)
                {
                    var chkbox = gvrow.FindControl("CheckBox1") as CheckBox;
                    if (chkbox.Checked)
                    {
                        cmd.Parameters.AddWithValue("OID", Int32.Parse(gvrow.Cells[1].Text));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Parameters.Clear();
                    }
                }
                GridView4.DataBind();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string update_sql = "UPDATE order_header SET status = 'prepared' WHERE order_id = @OID;";
            SqlConnection con = (SqlConnection)Application["conobj"];
            SqlCommand cmd = new SqlCommand(update_sql, con);
            try
            {
                foreach (GridViewRow gvrow in GridView3.Rows)
                {
                    var chkbox = gvrow.FindControl("CheckBox1") as CheckBox;
                    if (chkbox.Checked)
                    {
                        cmd.Parameters.AddWithValue("OID", Int32.Parse(gvrow.Cells[1].Text));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmd.Parameters.Clear();
                    }
                }
                GridView3.DataBind();
            }
            catch (Exception err)
            {
                Response.Write(err.Message);
                con.Close();
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("notification.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View_Can_Profile.aspx");
        }
    }
}