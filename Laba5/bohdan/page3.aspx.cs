using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laba5
{

    public partial class page3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null
                 || (!Request.UrlReferrer.OriginalString.Contains("page2")
                 && !Request.UrlReferrer.OriginalString.Contains("page3"))) Response.Redirect("error.aspx");
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            if (!IsValid) return;

            Session["code"] = TextBox1.Text;
            Response.Redirect("page4.aspx");
        }

        protected void CustomValidator_Requied(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value != "");
        }

    }
}