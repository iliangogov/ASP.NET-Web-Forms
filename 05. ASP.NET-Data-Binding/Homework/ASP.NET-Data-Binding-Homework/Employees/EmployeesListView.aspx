<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeesListView.aspx.cs" Inherits="Employees.EmployeesListView" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
         <asp:ListView ID="EmployeesListViewForm" runat="server" ItemType="Employees.Employee">
                <LayoutTemplate>
                    <h3>Employees</h3>
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                </LayoutTemplate>

                <ItemSeparatorTemplate>
                    <hr />
                </ItemSeparatorTemplate>

                <ItemTemplate>
                    <div class="employee-description">
                        <h4><%#: Item.FirstName + " " + Item.LastName %></h4>
                        <p>City: <%#: Item.City %></p>
                    </div>
                </ItemTemplate>
            </asp:ListView>

            <asp:DataPager ID="DataPagerEmployee" runat="server"
                           PagedControlID="EmployeesListViewForm" PageSize="3"
                           QueryStringField="page">
                <Fields>
                    <asp:NextPreviousPagerField ShowFirstPageButton="true"
                                                ShowNextPageButton="false" ShowPreviousPageButton="false" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ShowLastPageButton="true"
                                                ShowNextPageButton="false" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
    </div>

</asp:Content>