<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Employees.Employees" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:GridView ID="EmployeesGridView" runat="server" AutoGenerateColumns="False" 
                          AllowPaging="True" DataKeyNames="EmployeeID">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:BoundField DataField="HomePhone" HeaderText="Phone" />
                    <asp:HyperLinkField Text="Details" DataNavigateUrlFields="EmployeeID"
                                        DataNavigateUrlFormatString="EmployeeDetails.aspx?id={0}" />
                </Columns>
            </asp:GridView>
    </div>

</asp:Content>