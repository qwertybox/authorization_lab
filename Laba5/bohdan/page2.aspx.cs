using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laba5
{
    public class Emailer
    {
        public static void SendEmail(string To, string Subject, string Text)
        {
            try
            {
                //Авторизация на SMTP сервере
                SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
                Smtp.EnableSsl = true;
                Smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                Smtp.UseDefaultCredentials = false;
                Smtp.Credentials = new NetworkCredential("mail", "password");
                Smtp.Timeout = 20000;
                //Формирование письма
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress("mail");
                Message.To.Add(new MailAddress(To));
                Message.Subject = Subject;
                Message.Body = Text;

                Smtp.Send(Message);//отправка
            }
            catch (Exception)
            {
            }
        }
    }

    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null) Response.Redirect("error.aspx");

            if (IsPostBack)
            {
                if (!(String.IsNullOrEmpty(TextBox5.Text.Trim())))
                {
                    TextBox5.Attributes["value"] = TextBox5.Text;
                }
                if (!(String.IsNullOrEmpty(TextBox6.Text.Trim())))
                {
                    TextBox6.Attributes["value"] = TextBox6.Text;
                }
            }
            else
            { 
                DropDownList1.Items.Add(new ListItem("", "0"));
                DropDownList1.Items.Add(new ListItem("1 курс", "1"));
                DropDownList1.Items.Add(new ListItem("2 курс", "2"));
                DropDownList1.Items.Add(new ListItem("3 курс", "3"));
                DropDownList1.Items.Add(new ListItem("4 курс", "4"));
                DropDownList1.Items.Add(new ListItem("5 курс", "5"));
                DropDownList1.Items.Add(new ListItem("6 курс", "6"));

                DropDownList2.Items.Add(new ListItem("", "0"));
                DropDownList2.Items.Add(new ListItem("Механіко-математичний", "1"));
                DropDownList2.Items.Add(new ListItem("Радіофізичний", "2"));
                DropDownList2.Items.Add(new ListItem("Геологічний", "3"));
                DropDownList2.Items.Add(new ListItem("Історичний", "4"));
                DropDownList2.Items.Add(new ListItem("Філософський", "5"));

                DropDownList3.Items.Add(new ListItem("", "0"));
                DropDownList3.Items.Add(new ListItem("Наукова бібліотека", "1"));
                DropDownList3.Items.Add(new ListItem("Ботанічний сад", "2"));
                DropDownList3.Items.Add(new ListItem("Інформаційно-обчислювальний центр", "3"));
                DropDownList3.Items.Add(new ListItem("Ректорат", "4"));
            }
        }

        protected void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                CheckBox2.Checked = false;
                CheckBox2.Enabled = false;

                CheckBox3.Checked = false;
                CheckBox3.Enabled = false;

                DropDownList1.Enabled = true;
                DropDownList2.Enabled = true;
                DropDownList3.Enabled = false;
                DropDownList3.SelectedValue = "0";
            }
            if (RadioButton2.Checked)
            {
                CheckBox2.Enabled = true;

                CheckBox3.Enabled = true;

                DropDownList1.Enabled = false;
                DropDownList1.SelectedValue = "0";
                DropDownList2.Enabled = true;
                DropDownList3.Enabled = false;
                DropDownList3.SelectedValue = "0";
            }
            if (RadioButton3.Checked)
            {
                CheckBox2.Enabled = true;

                CheckBox3.Checked = false;
                CheckBox3.Enabled = false;

                DropDownList1.Enabled = false;
                DropDownList1.SelectedValue = "0";
                DropDownList2.Enabled = false;
                DropDownList2.SelectedValue = "0";
                DropDownList3.Enabled = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            if (!IsValid) return;

            UsersDbContext db = new UsersDbContext();

            var random = new Random();

            int UserType = 0;
            if (RadioButton1.Checked) UserType = 1;
            if (RadioButton2.Checked) UserType = 2;
            if (RadioButton3.Checked) UserType = 3;

            var user = new Users {
                Name = TextBox1.Text,
                SurName = TextBox2.Text,
                Login = TextBox3.Text,
                Email = TextBox4.Text,
                Password = TextBox5.Text,
                Type = UserType,
                IsMaster = CheckBox1.Checked,
                IsCandidat = CheckBox2.Checked,
                IsDoctor = CheckBox3.Checked,
                Curse = DropDownList1.SelectedValue,
                Faculty = DropDownList2.SelectedValue,
                StructPidr = DropDownList3.SelectedValue,
                SystemCode = random.Next(100000).ToString()
            };

            if (FileUpload1.HasFile)
            {
                user.Picture = FileUpload1.FileBytes;
                user.PictureType = "image/" + FileUpload1.FileName.Split('.')[1];
            }

            Emailer.SendEmail(TextBox4.Text, "Реєстрація", "Ваш код " + user.SystemCode);

            db.Users.Add(user);

            db.SaveChanges();



            Session["user"] = TextBox3.Text;

            Response.Redirect("page3.aspx");
        }


        protected void CustomValidator_SameValidation(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (TextBox5.Text == TextBox6.Text);
        }

        protected void CustomValidator_Requied(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value != "");
        }


        protected void CustomValidator_Login(object source, ServerValidateEventArgs args)
        {
            UsersDbContext db = new UsersDbContext();
            args.IsValid = !db.Users.Any(u=>u.Login == args.Value);
        }
    }
}