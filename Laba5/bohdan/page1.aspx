<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="Laba5.page1" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <h2>Сайт з авторизованим доступом</h2>
    <div>
        <table>
            <tr>
                <td>
                    Логін :
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox1" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Пароль :
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox2" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
            </tr>
        </table>      
    </div>
    <asp:Button ID="Button1" runat="server" Text="Вхід" OnClick="Button1_Click" OnClientClick="hide()" ValidateRequestMode="Enabled" />
    <asp:Button ID="Button2" runat="server" Text="Реєстрація" OnClick="Button2_Click" OnClientClick="hide()" CausesValidation="False" />
</asp:Content>




