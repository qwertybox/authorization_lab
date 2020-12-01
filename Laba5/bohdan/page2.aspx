<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="Laba5.page2" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <div>
        Фотографія (JPEG/PNG, min 100x150, max 200x300):&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" ViewStateMode="Disabled" />
        &nbsp;<asp:CustomValidator ID="CustomValidator7" runat="server" ErrorMessage="Виберіть картинку" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="FileUpload1" ValidateEmptyText="True"></asp:CustomValidator>
        <br />
        <br />
        <table>
            <tr>
                <td>Ім'я:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox1" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>Прізвище:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                <td>
                    <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox2" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>Логін:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                <td>
                    <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox3" ValidateEmptyText="True"></asp:CustomValidator>
                    <br />
                    <asp:CustomValidator ID="CustomValidator8" runat="server" ErrorMessage="Такий користувач вже існує" ForeColor="Red" OnServerValidate="CustomValidator_Login" ControlToValidate="TextBox3"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>E-mail:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox></td>
                <td>
                    <asp:CustomValidator ID="CustomValidator5" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox4" ValidateEmptyText="True"></asp:CustomValidator></td>
            </tr>
            <tr>
                <td>Пароль:</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:CustomValidator ID="CustomValidator6" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox5" ValidateEmptyText="True"></asp:CustomValidator></td>
            </tr>
            <tr>
                <td>Ще раз:</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="Password" ></asp:TextBox></td>
                <td>
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Паролі не збігаються" ControlToValidate="TextBox6" OnServerValidate="CustomValidator_SameValidation" ForeColor="Red" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
            </tr>
        </table>

        <br />
        <br />

        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Group1" OnCheckedChanged="RadioButton_CheckedChanged" Text="Студент" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" Checked="True" GroupName="Group1" OnCheckedChanged="RadioButton_CheckedChanged" Text="Викладач" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Group1" OnCheckedChanged="RadioButton_CheckedChanged" Text="Навчально-допоміжний персонал" AutoPostBack="True" />

        <br />
        <br />

        <asp:CheckBox ID="CheckBox1" runat="server" Text="Майстер спорту" />
        &nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Кандидат наук" />
        &nbsp;
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Доктор наук" />

        <br />
        <br />
        Курс :
        <asp:DropDownList ID="DropDownList1" runat="server" Enabled="False"></asp:DropDownList>
        <br />
        Факультет :
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        <br />
        Структурний підрозділ :
        <asp:DropDownList ID="DropDownList3" runat="server" Enabled="False"></asp:DropDownList>
        <br />
        <br />
    </div>
    <asp:Button ID="Button2" runat="server" Text="Далі" OnClick="Button2_Click" OnClientClick="hide()" />
</asp:Content>
