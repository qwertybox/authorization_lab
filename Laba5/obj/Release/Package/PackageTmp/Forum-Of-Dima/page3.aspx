<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="Laba5.page3" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <h2>Верифікація адреси електронної пошти</h2>
    <div>
        На вашу адресу направлений одноразовий пароль.
        <br />
        Введіть його в поле:<br />
        &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Поле має бути заповненим" ForeColor="Red" OnServerValidate="CustomValidator_Requied" ControlToValidate="TextBox1" ValidateEmptyText="True"></asp:CustomValidator>
        <br />
    </div>
    <asp:Button ID="Button2" runat="server" Text="Зреєструвати" OnClick="Button2_Click" OnClientClick="hide()" />
</asp:Content>
