<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Countries._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListBox ID="ListBoxContinents" runat="server"
        DataTextField="Name" DataValueField="Id"
        SelectMethod="ListBoxContinents_GetData"
        ItemType="Countries.Data.Models.Continent"
        DataKeyNames="Id"
        UpdateMethod="ListBoxContinents_UpdateItem"
        AutoGenerateEditButton="true"
        AutoGenerateColumns="false"
        AutoPostBack="true"
        OnSelectedIndexChanged="ListBoxContinents_SelectedIndexChanged" />

    <asp:GridView ID="GridViewCountries" runat="server"
        SelectMethod="GridViewCountries_GetData"
        DataKeyNames="Id"
        AllowPaging="true" AllowSorting="true"
        AutoGenerateColumns="True"
        ViewStateMode="Enabled"
        PageSize="2"
        PagerSettings-Mode="NumericFirstLast"
        OnRowDataBound="GridViewCountries_RowDataBound"
        OnSelectedIndexChanged="GridViewCountries_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>

    <asp:ListView ID="ListViewTowns" runat="server"
        ItemType="Countries.Data.Models.Town"
        SelectMethod="ListViewTowns_GetData">
        <LayoutTemplate>
            <h3>Towns</h3>
            <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
        </LayoutTemplate>

        <ItemSeparatorTemplate>
            <hr />
        </ItemSeparatorTemplate>

        <ItemTemplate>
            <div class="product-description">
                <h4><%#: Item.Name %></h4>
                Population: <%#: Item.Population %>
            </div>
        </ItemTemplate>
    </asp:ListView>

    <asp:DataPager ID="DataPagerTowns" runat="server"
        PagedControlID="ListViewTowns" PageSize="5"
        QueryStringField="page"
        EnableViewState="true"
        ViewStateMode="Enabled">
        <Fields>
            <asp:NextPreviousPagerField ShowFirstPageButton="true"
                ShowNextPageButton="false" ShowPreviousPageButton="false" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ShowLastPageButton="true"
                ShowNextPageButton="false" ShowPreviousPageButton="false" />
        </Fields>
    </asp:DataPager>

</asp:Content>
