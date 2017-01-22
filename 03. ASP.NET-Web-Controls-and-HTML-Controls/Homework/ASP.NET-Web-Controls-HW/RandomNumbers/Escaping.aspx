<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Escaping.aspx.cs" Inherits="WebControlsHomework.Escaping" %>

<asp:content contentplaceholderid="MainContent" runat="server">
    <div class="jumbotron">
       <asp:TextBox runat="server" Placeholder="Enter some text here..." ID="mainTextBox" ValidateRequestMode="Disabled" />
            <asp:Button Text="submit" runat="server" OnClick="OnSubmitButtonClicked" CssClass="btn btn-success" />

            <br /> <br />

            <asp:TextBox runat="server" ID="enteredTextBox" ValidateRequestMode="Disabled" /> <br /> <br />
            <asp:Label runat="server" ID="enteredTextLabel" ValidateRequestMode="Disabled" />
    </div>
</asp:content>