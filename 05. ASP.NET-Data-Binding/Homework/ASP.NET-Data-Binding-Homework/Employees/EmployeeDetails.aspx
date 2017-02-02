<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="Employees.EmployeeDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:DetailsView ID="EmployeeDetailsView" runat="server" 
                             AutoGenerateRows="true" AllowPaging="True" >
            </asp:DetailsView>

            <br /> <br />

            <asp:Button Text="Back" runat="server" OnClick="OnBackButtonClicked" />
    </div>

</asp:Content>