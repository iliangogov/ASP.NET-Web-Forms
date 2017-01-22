<%@ Page Title="Random Numbers Web" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RandomNumbersWeb.aspx.cs" Inherits="RandomNumbers.RandomNumbersWeb" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="FirstNumberLabel" runat="server" Text="From: "></asp:Label>
        <asp:TextBox ID="FirstNumberInput" runat="server" Text="0"></asp:TextBox>
        <asp:Label ID="SecondNumberLabel" runat="server" Text="To: "></asp:Label>
        <asp:TextBox ID="SecondNumberInput" runat="server" Text="0"></asp:TextBox><hr />
        <asp:Button ID="SubmitButton" runat="server" Text="Get number" OnClick="SubmittButton_Click" CssClass="btn btn-success" /><hr />
        <asp:Label ID="ResultLabel" runat="server" Text="Your random nuber: "></asp:Label>
        <asp:TextBox ID="ResultInput" runat="server" disabled="disabled"></asp:TextBox>
    </div>
</asp:Content>