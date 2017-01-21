<%@ Page Title="Sumator Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sumator.aspx.cs" Inherits="SumatorWebForms.Sumator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Enter two numbers and I'll sum them. Believe it or not.</h3>
        <asp:Label ID="FirstNumberLabel" runat="server" Text="Enter first number: "></asp:Label>
        <asp:TextBox ID="FirstNumberInput" runat="server"></asp:TextBox>
        <asp:Label ID="SecondNumberLabel" runat="server" Text="Enter second number: "></asp:Label>
        <asp:TextBox ID="SecondNumberInput" runat="server"></asp:TextBox>
        <asp:Label ID="ResultLabel" runat="server" Text="Result: "></asp:Label>
        <asp:TextBox ID="ResultInput" runat="server"></asp:TextBox>
        <asp:Button ID="SumButton" runat="server" Text="Calculate" OnClick="CalculateSum_Click" CssClass="btn btn-success " ToolTip="Click to see the sum" />
        <asp:Button ID="ClearButton" runat="server" Text="Clear" OnClick="ClearForm_Click" CssClass="btn btn-warning " ToolTip="Click to clear the fields" />
        <div class="hidden" ID="Notifier" runat="server"></div>
        <p><a href="/" class="btn btn-primary">Back &raquo;</a></p>
    </div>


</asp:Content>
