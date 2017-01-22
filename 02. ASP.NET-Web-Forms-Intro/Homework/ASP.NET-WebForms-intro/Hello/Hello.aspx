<%@ Page Title="Hello ASP.NET from aspx code!" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="Hello.Hello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="NameLabel" runat="server" Text="Enter your name: "></asp:Label>
        <asp:TextBox ID="NameInput" runat="server"></asp:TextBox>
        <asp:Button ID="NameButton" runat="server" Text="Submit" OnClick="NameButton_Click" />
        <div class="hidden" id="Notifier" runat="server"></div>
        <hr />
        <div id="CodeBehindHello" runat="server"></div>
        <hr />
        <div><%: Title %></div>
        <hr />
        <div id="CurrentLocation" runat="server"></div>
    </div>
</asp:Content>
