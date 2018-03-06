using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickCanteen
{
    public partial class View_Stu_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["logged_in"].Equals(true) && Session["role"].Equals("student")))
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            student_master student = db.student_masters.Single(student_master => student_master.id == (int)Session["id"]);
            student.wallet += Int32.Parse(TextBox1.Text);            
            db.SubmitChanges();
            DetailsView1.DataBind();                                  
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            student_master student = db.student_masters.Single(student_master => student_master.id == (int)Session["id"]);
            student.wallet -= Int32.Parse(TextBox2.Text);
           // db.student_masters.InsertOnSubmit(student);
            db.SubmitChanges();
            DetailsView1.DataBind();
        }
    }
}