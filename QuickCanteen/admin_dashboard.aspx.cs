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
    public partial class admin_dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["logged_in"].Equals(false))
            {
                Response.Redirect("login.aspx");
            }
            var db = new QCDBMLDataContext();
            int student_count = (from student in db.student_masters select student.id).Count();
            Label1.Text = student_count.ToString();
            int canteen_count = (from canteen in db.canteen_masters select canteen.canteen_id).Count();
            Label2.Text = student_count.ToString();
        }        
    }
}