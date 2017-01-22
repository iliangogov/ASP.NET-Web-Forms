<%@ Page Title="Dump Events page!" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Dump.aspx.cs" Inherits="Hello.Dump" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="wrapper" runat="server">
            <asp:Button ID="mainButton" 
                        runat="server" 
                        OnInit="OnButtonInit" 
                        OnLoad="OnButtonLoad" 
                        OnClick="OnButtonClicked" 
                        OnPreRender="OnButtonPreRender" 
                        Text="Press" />
            <br />
            <asp:Label runat="server" ID="textBlock"></asp:Label>
        </div>
</asp:Content>
