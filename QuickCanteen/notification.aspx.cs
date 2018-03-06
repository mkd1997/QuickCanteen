using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuickCanteen
{
    public partial class notification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["logged_in"].Equals(true)))
            {
                Response.Redirect("~/login.aspx");
            }
            
                Notif_Table.Rows.Clear();
                if (Session["role"].ToString().Contains("student"))
                {
                    showStudentNotifs();
                }
                else if(Session["role"].ToString().Contains("manager"))
                {
                    showCanteenNotifs();
                }
                else
                {
                    Debug.Write("Page Load else of Notification");
                }
            
        }

        protected void showCanteenNotifs()
        {
            int id = Convert.ToInt32(Session["id"]);
            QCDBMLDataContext ctx = new QCDBMLDataContext();
            var notifs = from notif in ctx.canteen_notification_masters where notif.canteen_id == id select notif;
            if (notifs!=null && notifs.Count<canteen_notification_master>() > 0)
            {
                foreach(canteen_notification_master s in notifs)
                {
                    TableRow tr = new TableRow();
                    TableCell c1 = new TableCell();
                    Label lmsg = new Label();
                    lmsg.Text = s.message;
                    c1.Controls.Add(lmsg);
                    tr.Cells.Add(c1);
                    TableCell c2 = new TableCell();
                    c2.Text = "Date :" + s.not_date.Value.ToShortDateString();
                    tr.Cells.Add(c2);
                    LinkButton link = new LinkButton();
                    link.Text = "Approve";
                    link.Command += new CommandEventHandler(ApproveNotifStu);
                    link.CommandName = s.canteen_id.ToString();
                    link.CommandArgument = s.message;
                    TableCell c3 = new TableCell();
                    c3.Controls.Add(link);
                    tr.Cells.Add(c3);
                    LinkButton link1 = new LinkButton();
                    link1.Text = "Reject";
                    link1.Command += new CommandEventHandler(RejectNotifStu);
                    link1.CommandName = s.canteen_id.ToString();
                    link1.CommandArgument = s.message;
                    TableCell c4 = new TableCell();
                    c4.Controls.Add(link1);
                    tr.Cells.Add(c4);
                    Notif_Table.Rows.Add(tr);
                }
            }
            else
            {
                Debug.Write("Else of Canteen Notif");
            }
        }

        protected void showStudentNotifs()
        {
            int id = Convert.ToInt32(Session["id"]);
            QCDBMLDataContext ctx = new QCDBMLDataContext();
            var notifs = from notif in ctx.student_notification_masters where notif.student_id == id select notif;
            if (notifs != null && notifs.Count<student_notification_master>() > 0)
            {
                foreach (student_notification_master s in notifs)
                {
                    TableRow tr = new TableRow();
                    TableCell c1 = new TableCell();
                    Label lmsg = new Label();
                    lmsg.Text = s.message;
                    c1.Controls.Add(lmsg);
                    tr.Cells.Add(c1);
                    TableCell c2 = new TableCell();
                    c2.Text = "Date :" + s.not_date.ToShortDateString();
                    tr.Cells.Add(c2);
                    LinkButton link = new LinkButton();
                    link.Text = "Dismiss";
                    link.Command += new CommandEventHandler(DismissNotfStu);
                    link.CommandName = s.student_id.ToString();
                    link.CommandArgument = s.message;
                    TableCell c3 = new TableCell();
                    c3.Controls.Add(link);
                    tr.Cells.Add(c3);
                    Notif_Table.Rows.Add(tr);
                }
            }
            else
            {
                Debug.Write("Else of Student Notif");
            }
        }

        protected void ApproveNotifStu(object o,CommandEventArgs e)
        {
            string msg = e.CommandArgument.ToString();
            int index = msg.IndexOf("order ID: ");
            int o_id = Convert.ToInt32(msg.Substring(index+9));
            int s_id;
            QCDBMLDataContext ctx = new QCDBMLDataContext();
            var order = ctx.order_headers.Single(order_header => order_header.order_id == o_id);
            order.status = "can_app";
            ctx.SubmitChanges();
            //var notif = ctx.canteen_notification_masters.Single(canteen_notification_master => canteen_notification_master.canteen_id.ToString() == e.CommandName && canteen_notification_master.message == e.CommandArgument.ToString());
            string cons = WebConfigurationManager.ConnectionStrings["QuickCanteenDBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            string q = "delete from canteen_notification_master where canteen_id=" + Convert.ToInt32(e.CommandName) + " AND message='" + e.CommandArgument.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            /*if(order != null)
            {
                s_id = order.stu_id;
                var o_details = ctx.order_details.Single(order_detail => order_detail.order_id == order.order_id);
                if(o_details != null)
                {
                    ctx.order_details.DeleteOnSubmit(o_details);
                }
                ctx.order_headers.DeleteOnSubmit(order);
                student_notification_master snm = new student_notification_master();
                snm.student_id = s_id;
                snm.message = "Your Cancellation Of Order No: " + o_id + " Approved !";
                snm.not_date = DateTime.Now;
                ctx.student_notification_masters.InsertOnSubmit(snm);
                var notif = ctx.canteen_notification_masters.Single(canteen_notification_master => canteen_notification_master.canteen_id.ToString() == e.CommandName && canteen_notification_master.message == e.CommandArgument.ToString());
                if(notif != null)
                {
                    ctx.canteen_notification_masters.DeleteOnSubmit(notif);
                }
                ctx.SubmitChanges();
            }*/
        }

        protected void RejectNotifStu(object o, CommandEventArgs e)
        {
            string msg = e.CommandArgument.ToString();
            int index = msg.IndexOf("order ID: ");
            int o_id = Convert.ToInt32(msg.Substring(index + 9));
            int s_id;
            QCDBMLDataContext ctx = new QCDBMLDataContext();
            var order = ctx.order_headers.Single(order_header => order_header.order_id == o_id);
            order.status = "can_deny";
            ctx.SubmitChanges();
            string cons = WebConfigurationManager.ConnectionStrings["QuickCanteenDBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            string q = "delete from canteen_notification_master where canteen_id=" + Convert.ToInt32(e.CommandName) + " AND message='" + e.CommandArgument.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            /*if (order != null)
            {
                s_id = order.stu_id;
                student_notification_master snm = new student_notification_master();
                snm.student_id = s_id;
                snm.message = "Your Cancellation Of Order No: " + o_id + " Rejected !";
                snm.not_date = DateTime.Now;
                ctx.student_notification_masters.InsertOnSubmit(snm);
                var notif = ctx.canteen_notification_masters.Single(canteen_notification_master => canteen_notification_master.canteen_id.ToString() == e.CommandName && canteen_notification_master.message == e.CommandArgument.ToString());
                if (notif != null)
                {
                    ctx.canteen_notification_masters.DeleteOnSubmit(notif);
                }
                ctx.SubmitChanges();
            }*/
        }

        protected void DismissNotfStu(object o,CommandEventArgs e)
        {
            //QCDBMLDataContext ctx = new QCDBMLDataContext();
            //var notif = ctx.student_notification_masters.Single(student_notification_master => student_notification_master.student_id.ToString() == e.CommandName && student_notification_master.message == e.CommandArgument.ToString());
            string cons = WebConfigurationManager.ConnectionStrings["QuickCanteenDBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            string q = "delete from student_notification_master where student_id=" + Convert.ToInt32(e.CommandName) + " AND message='" + e.CommandArgument.ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
        }
    }
}