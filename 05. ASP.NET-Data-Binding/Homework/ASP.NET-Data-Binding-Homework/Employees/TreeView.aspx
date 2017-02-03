<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" Inherits="Employees.TreeView" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1"></asp:TreeView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Bookstore.xml"></asp:XmlDataSource>
    </div>

</asp:Content>
