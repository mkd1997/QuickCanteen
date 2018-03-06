using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Web.Configuration;

namespace QuickCanteen
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["QCDBCon"].ConnectionString;
            SqlConnection ConObj = new SqlConnection(constr);
            Application["conobj"] = ConObj;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["logged_in"] = false;
            Session["role"] = "guest";
            Session["id"] = -1;
            Session["food_id"] = -1;
            Session["can_id"] = -1;
            Session["fb_can_id"] = -1;
            Session["cart_obj"] = new List<FoodCartItem>();
            Session["tot_amt"] = -1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Session["logged_in"] = false;
            Session["role"] = "guest";
            Session["id"] = -1;
            Session["food_id"] = -1;
            Session["can_id"] = -1;
            Session["fb_can_id"] = -1;
            Session["cart_obj"] = null;
            Session["tot_amt"] = -1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}