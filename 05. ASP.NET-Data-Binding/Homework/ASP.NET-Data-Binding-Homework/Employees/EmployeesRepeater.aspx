<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeesRepeater.aspx.cs" Inherits="Employees.EmployeesRepeater" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Repeater ID="EmployeesRepeaterForm" runat="server" ItemType="Employees.Employee">
        <ItemTemplate>
            <div class="jumbotron">
                <h4><%#: Item.FirstName + " " + Item.LastName %></h4>
                <table border="0">
                    <tr>
                        <td>Phone:</td>
                        <td><%#: Item.HomePhone %></td>
                    </tr>
                    <tr>
                        <td>Country:</td>
                        <td><%#: Item.Country %></td>
                    </tr>
                    <tr>
                        <td>City:</td>
                        <td><%#: Item.City %></td>
                    </tr>
                </table>
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
