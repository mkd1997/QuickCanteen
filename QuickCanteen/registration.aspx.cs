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
using System.Net;
using System.Net.Mail;

namespace QuickCanteen
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if(!IsPostBack)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
        }

        protected void SendMail(string RcptEmail)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("manavdesai1997", "mkd180497");
            client.EnableSsl = true;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("manavdesai1997@gmail.com");
            message.To.Add(RcptEmail);
            message.Body = "Thank you for registering\nQuickCanteen Team";
            message.Subject = "QuickCanteen Account Created";
            client.Send(message);

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedValue.Equals("student"))
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else if(RadioButtonList1.SelectedValue.Equals("manager"))
            {
                Panel2.Visible = true;
                Panel1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = (SqlConnection)Application["conobj"];            
            if(TextBox4.Text.Equals(TextBox9.Text))
            {
                string stu_insert = "INSERT INTO student_master (name, college, uname, pass, wallet, bdate, ph_no, email) VALUES (@st_name, @st_college, @st_uname, @st_pass, @st_wallet, @st_bday, @st_no, @st_email)";
                SqlCommand st_insert = new SqlCommand(stu_insert, con);
                st_insert.Parameters.AddWithValue("@st_name", TextBox1.Text + " " + TextBox2.Text);
                st_insert.Parameters.AddWithValue("@st_college", TextBox10.Text);
                st_insert.Parameters.AddWithValue("@st_uname", TextBox3.Text);
                st_insert.Parameters.AddWithValue("@st_pass", TextBox4.Text);
                st_insert.Parameters.AddWithValue("@st_wallet", Int32.Parse(TextBox8.Text));
                st_insert.Parameters.AddWithValue("@st_bday", TextBox6.Text);
                st_insert.Parameters.AddWithValue("@st_no", Int64.Parse(TextBox7.Text));
                st_insert.Parameters.AddWithValue("@st_email", TextBox5.Text);                    

                int added = 0;
                try
                {
                    con.Open();
                    added = st_insert.ExecuteNonQuery();
                    con.Close();
                    Label2.Text = "Thanks for Registering. An email stating your details has been sent to you.";
                    SendMail(TextBox5.Text);

                }
                catch (Exception err)
                {
                    Label3.Text = err.Message;
                    con.Close();
                }
            }
            else
            {
                Response.Write("Passwords do not match");
            }            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = (SqlConnection)Application["conobj"];
            if (TextBox4.Text.Equals(TextBox9.Text))
            {
                string ct_insert_sql = "INSERT INTO canteen_master (canteen_name, uname, pass, wallet, ph_no, email, open_time, close_time, order_limit) VALUES (@ct_name, @ct_uname, @ct_pass, @ct_wallet, @ct_no, @ct_email, @ct_otime, @ct_ctime, @ct_ol);";
                SqlCommand ct_insert = new SqlCommand(ct_insert_sql, con);
                ct_insert.Parameters.AddWithValue("@ct_name", TextBox11.Text);
                ct_insert.Parameters.AddWithValue("@ct_uname", TextBox14.Text);
                ct_insert.Parameters.AddWithValue("@ct_pass", TextBox15.Text);
                ct_insert.Parameters.AddWithValue("@ct_otime", TextBox12.Text);
                ct_insert.Parameters.AddWithValue("@ct_wallet", Int32.Parse(TextBox20.Text));
                ct_insert.Parameters.AddWithValue("@ct_ctime", TextBox13.Text);
                ct_insert.Parameters.AddWithValue("@ct_no", Int64.Parse(TextBox18.Text));
                ct_insert.Parameters.AddWithValue("@ct_email", TextBox19.Text);
                ct_insert.Parameters.AddWithValue("@ct_ol", Int32.Parse(TextBox17.Text));

                int added = 0;
                try
                {
                    con.Open();
                    added = ct_insert.ExecuteNonQuery();
                    con.Close();
                    Label2.Text = "Thanks for Registering. An email stating your details has been sent to you.";
                    SendMail(TextBox19.Text);
                }
                catch (Exception err)
                {
                    Label3.Text = err.Message;
                    con.Close();
                }
            }
            else
            {
                Response.Write("Passwords do not match");
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}