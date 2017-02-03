<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeesFormView.aspx.cs" Inherits="Employees.EmployeesFormView" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" >
            <asp:GridView ID="EmployeesGridView" runat="server" AutoGenerateColumns="False"
                AllowPaging="True" DataKeyNames="EmployeeID">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:BoundField DataField="HomePhone" HeaderText="Phone" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:HyperLinkField Text="Details" DataNavigateUrlFields="EmployeeID" DataNavigateUrlFormatString="EmployeesFormView.aspx?id={0}" />
                </Columns>
            </asp:GridView>
        <br />
        <div runat="server" id="SelectedEmployeeContainer" visible="false" >
            <h2>Selected Employee: </h2>
            <asp:FormView ID="EmployeeFormView" runat="server" DataKeyName="EmployeeID" ItemType="Employees.Employee">
                <ItemTemplate>
                    <h4><%#: Item.FirstName + " " + Item.LastName %></h4>
                    <table border="0">
                        <tr>
                            <td>Phone:</td>
                            <td><%#: Item.HomePhone %></td>
                        </tr>
                        <tr>
                            <td>City:</td>
                            <td><%#: Item.City %></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:FormView>
        </div>
    </div>

</asp:Content>
