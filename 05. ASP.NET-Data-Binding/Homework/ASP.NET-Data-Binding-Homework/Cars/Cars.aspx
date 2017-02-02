<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="Cars.Cars" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
         Producer:
            <asp:DropDownList ID="ProducersDropDownList" runat="server" 
                AutoPostBack="True" DataTextField="Name" OnSelectedIndexChanged="OnProducerSelectedIndexChanged">
            </asp:DropDownList>
            <br />

         Model:
            <asp:DropDownList ID="ProducerModelsDropDownList" runat="server" 
                ItemType="Mobile.Producer" DataTextField="Name">
            </asp:DropDownList>
            <br /> 

        Extras:
            <asp:CheckBoxList ID="ExtrasCheckBoxList" runat="server" DataTextField="Name">
            </asp:CheckBoxList>

            <br />

        Engine:
            <asp:RadioButtonList ID="EnginesRadioButtonList" runat="server" RepeatDirection="Horizontal">
            </asp:RadioButtonList>

            <br />

            <asp:Button Text="Search" runat="server" OnClick="OnSearchButtonClicked" />

            <br />

        <asp:Literal ID="SummaryLiteral" runat="server"></asp:Literal>
    </div>
</asp:Content>