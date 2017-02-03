<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Employees._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Data Binding Homework </h1>
        <p>If you can't connect to DB take care of connection string in Web.config file</p>
        <p><a href="/Employees" class="btn btn-primary btn-lg">Task 2 Employees (GridView).. &raquo;</a></p>
        <p><a href="/EmployeesFormView" class="btn btn-primary btn-lg">Task 2 Employees (FormView).. &raquo;</a></p>
         <p><a href="/EmployeesRepeater" class="btn btn-primary btn-lg">Task 2 Employees (Repeater).. &raquo;</a></p>
    </div>

</asp:Content>
