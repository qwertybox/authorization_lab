using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laba5
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsersDbContext db = new UsersDbContext();

            string login = (string)Session["user"];

            var user = db.Users.Single(u => u.Login == login);

            Byte[] bytes = user.Picture;
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = user.PictureType;
            Response.AddHeader("content-disposition", "attachment;filename=Dima");
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }
    }
}