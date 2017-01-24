<%@ Page Language="C#" MasterPageFile="~/PersonalInfo.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="SeparateMasterPages.Info" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3><strong> Name</strong>:</h3>
        <p > Petar</p>
        <h3><strong>Age</strong>:</h3>
        <p > 16</p>
        <i>This view is useing different Master Page! Navigation color is to proove it!</i>
    </div>

</asp:Content>
