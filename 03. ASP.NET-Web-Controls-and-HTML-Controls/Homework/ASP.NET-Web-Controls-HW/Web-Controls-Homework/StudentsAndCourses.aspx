<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentsAndCourses.aspx.cs" Inherits="WebControlsHomework.StudentsAndCourses" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div runat="server" id="registerForm" class="jumbotron">
        First name:
        <asp:TextBox runat="server" ID="firstNameInput" />
        <br />
        <br />
        Second name:
        <asp:TextBox runat="server" ID="lastNameInput" />
        <br />
        <br />
        Faculty number:
        <asp:TextBox runat="server" ID="facultyNumber" />
        <br />
        <br />
        University: 
                <asp:DropDownList runat="server" ID="universityDropDown">
                    <asp:ListItem Text="Technical University" />
                    <asp:ListItem Text="Sofia University" />
                    <asp:ListItem Text="Cambridge" />
                    <asp:ListItem Text="Oxford" />
                </asp:DropDownList>
        <br />
        <br />
        Specialty: 
                <asp:DropDownList runat="server" ID="specialtyDropDown">
                    <asp:ListItem Text="Web developer" />
                    <asp:ListItem Text="Mobile developer" />
                    <asp:ListItem Text="Code Monkey" />
                    <asp:ListItem Text="Architect" />
                </asp:DropDownList>
        <br />
        <br />
        Course: 
                <asp:DropDownList runat="server" ID="courseDropDown">
                    <asp:ListItem Text="C#" />
                    <asp:ListItem Text="Java Script" />
                    <asp:ListItem Text="HTML" />
                    <asp:ListItem Text="Phyton" />
                </asp:DropDownList>
        <br />
        <br />
        <asp:Button Text="Register" runat="server" OnClick="OnRegisterStudentButtonClicked" CssClass="btn btn-success" />
    </div>
    <div runat="server" id="registrationInfo"></div>
</asp:Content>
