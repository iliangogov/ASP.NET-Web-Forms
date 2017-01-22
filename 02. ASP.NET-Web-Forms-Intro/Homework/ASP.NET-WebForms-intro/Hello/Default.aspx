<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hello._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">Click the button "Go to Hello page" or navigate to /Hello to see the Hello demo...</p>
        <p class="lead">Click the button "Go to Dump Events page" or navigate to /Dump to see the Dump Events demo...</p>
        <p><a href="Hello" class="btn btn-primary btn-lg">Go to Hello page &raquo;</a></p>
        <p><a href="Dump" class="btn btn-primary btn-lg">Go to Dump Events page &raquo;</a></p>
    </div>

</asp:Content>
