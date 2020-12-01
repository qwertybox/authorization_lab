using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laba5
{
    public partial class page4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null
                || (!Request.UrlReferrer.OriginalString.Contains("page3")
                && !Request.UrlReferrer.OriginalString.Contains("page4"))) Response.Redirect("error.aspx");

            UsersDbContext db = new UsersDbContext();

            string login = (string)Session["user"];

            var user = db.Users.Single(u => u.Login == login);

            if (user.SystemCode == (string)Session["code"])
            {
                Label2.Text = "Реєстрацію успішно завершено!";
                Label2.ForeColor = System.Drawing.Color.Green;
                user.IsVerificated = true;
            }
            else
            {
                Label2.Text = "Помилка реестрації!";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
            db.SaveChanges();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Response.Redirect("page1.aspx");
        }
    }
}