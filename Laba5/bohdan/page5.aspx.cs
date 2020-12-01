using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laba5
{
    public partial class page5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.UrlReferrer == null) Response.Redirect("error.aspx");

            if (Session["user"] != null)
            {
                UsersDbContext db = new UsersDbContext();

                string login = (string)Session["user"];

                var user = db.Users.Single(u => u.Login == login);

                Label1.Text = user.Name;
                Label2.Text = user.SurName;
                Label3.Text = user.Login;
                Label4.Text = user.Email;
            }
            else
            {
                Response.Redirect("error.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Redirect("page1.aspx");
        }
    }
}