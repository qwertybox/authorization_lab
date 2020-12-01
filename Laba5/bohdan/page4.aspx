<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page4.aspx.cs" Inherits="Laba5.page4" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="Server">
    <div>
        <h2><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h2>
        
    </div>
        <asp:Button ID="Button1" runat="server" Text="На головну" OnClick="Button1_Click" OnClientClick="hide()" />
</asp:Content>
