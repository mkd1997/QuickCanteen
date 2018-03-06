using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickCanteen
{
    public partial class View_Can_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["logged_in"].Equals(true) && Session["role"].Equals("manager")))
            {
                Response.Redirect("~/login.aspx");
            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            canteen_master canteen = db.canteen_masters.Single(canteen_master=> canteen_master.canteen_id == (int)Session["id"]);
            canteen.wallet += Int32.Parse(TextBox1.Text);
            db.SubmitChanges();
            DetailsView2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var db = new QCDBMLDataContext();
            canteen_master canteen = db.canteen_masters.Single(canteen_master => canteen_master.canteen_id == (int)Session["id"]);
            canteen.wallet -= Int32.Parse(TextBox2.Text);
            db.SubmitChanges();
            DetailsView2.DataBind();
        }
    }
}