<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page5.aspx.cs" Inherits="Laba5.page5" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">   
    <div>
    Вітаємо Вас на нашому сайті,<br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        &nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> !<br />
        &nbsp;<asp:Image ID="Image1" runat="server" ImageUrl="Image.aspx" Width="200px"  Height ="300px"/>
        <br />
        Логін ...... <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        E-mail ..... <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
    </div>
        <asp:Button ID="Button1" runat="server" Text="Вихід" OnClick="Button1_Click" OnClientClick="hide()" />
</asp:Content>
