using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laba5
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = null;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Redirect("page2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            if (!IsValid) return;

            UsersDbContext db = new UsersDbContext();

            var user = db.Users.SingleOrDefault(u => u.Login == TextBox1.Text && u.Password == TextBox2.Text && u.IsVerificated);

            if (user != null)
            {
                Session["user"] = user.Login;
                Response.Redirect("page5.aspx");
            }
            else
            {
                Response.Redirect("error.aspx");
            }
        }

        protected void CustomValidator_Requied(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value != "");
        }

    }
}