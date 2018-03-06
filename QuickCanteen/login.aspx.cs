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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pass = "";
            admin_master admin = new admin_master();
            canteen_master canteen = new canteen_master();
            student_master student = new student_master();
            /*int rows;
            string acc_select_SQL;
            SqlCommand acc_select = new SqlCommand();
            SqlConnection con = (SqlConnection)Application["conobj"];            */
            var db = new QCDBMLDataContext();
            if(RadioButtonList1.SelectedValue.Equals("admin"))
            {
                admin = db.admin_masters.Single(admin_master => admin_master.uname.Equals(TextBox1.Text));
                pass = admin.pass;              
                /*acc_select_SQL = "SELECT * FROM admin_master WHERE uname = @tb_uname;";
                acc_select.CommandText = acc_select_SQL;
                acc_select.Connection = con;
                acc_select.Parameters.AddWithValue("@tb_uname", TextBox1.Text);*/
            }
            else if(RadioButtonList1.SelectedValue.Equals("manager"))
            {
                canteen = db.canteen_masters.Single(canteen_master => canteen_master.uname.Equals(TextBox1.Text));
                pass = canteen.pass;
                /*acc_select_SQL = "SELECT * FROM canteen_master WHERE uname = @tb_uname;";
                acc_select.CommandText = acc_select_SQL;
                acc_select.Connection = con;*/
                //acc_select.Parameters.AddWithValue("@tb_uname", TextBox1.Text);
            }
            else if(RadioButtonList1.SelectedValue.Equals("student"))
            {
                student = db.student_masters.Single(student_master => student_master.uname.Equals(TextBox1.Text));
                pass = student.pass;
                /*acc_select_SQL = "SELECT * FROM student_master WHERE uname = @tb_uname;";
                acc_select.CommandText = acc_select_SQL;
                acc_select.Connection = con;
                acc_select.Parameters.AddWithValue("@tb_uname", TextBox1.Text);*/
            }
            else
            {
                Response.Write("Not Valid");
            }

            /*SqlDataAdapter adapter = new SqlDataAdapter(acc_select);
            DataSet dsAcc = new DataSet();

            try
            {
                con.Open();
                rows = adapter.Fill(dsAcc, "accounts");
                con.Close();
                if(rows != 0)
                {
                    foreach(DataRow row in dsAcc.Tables["accounts"].Rows)
                    {*/
                        if(TextBox2.Text.Equals(pass))
                        {
                            Session["logged_in"] = true;
                            Session["role"] = RadioButtonList1.SelectedValue;                            ;                 

                            switch(RadioButtonList1.SelectedValue)
                            {
                                case "admin":   Session["id"] = (int)admin.admin_id;
                                                Response.Redirect("admin_dashboard.aspx");                                    
                                    break;
                                case "manager": Session["id"] = (int)canteen.canteen_id;
                                                Response.Redirect("canteen_dashboard.aspx");
                                    break;
                                case "student": Session["id"] = (int)student.id;
                                                Response.Redirect("student_dashboard1.aspx");
                                    break;
                            }
                        }/*
                    }
                }
                else
                {
                    Response.Write("Invalid username/password");
                }
            }
            catch(Exception mess)
            {
                Response.Write(mess.Message);
                con.Close();
            }    */
        }
    }
}