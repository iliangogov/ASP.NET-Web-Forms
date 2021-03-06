﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebCalculator.aspx.cs" Inherits="WebControlsHomework.WebCalculator" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    
    <div runat="server" id="Calculator" class="jumbotron">
    <link href="Content/Calculator.css" rel="stylesheet" />
         <input type="text" runat="server" name="valueInMemory" ID="valueInMemory" hidden="hidden" />
            <input type="text" runat="server" name="lastSelectedOperator" ID="lastSelectedOperator" hidden="hidden" />
            <input type="text" runat="server" value="0" ID="resultBox"  />
            <ul>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="1" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="2" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="3" /></li>
                <li><input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="+" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="4" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="5" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="6" /></li>
                <li><input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="-" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="7" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="8" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="9" /></li>
                <li><input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="*" /></li>
                <li><input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="0" /></li>
                <li><input runat="server" onserverclick="OnRootButtonClicked" type="button" value="√" /></li>
                <li><input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="/" /></li>
                <li><input runat="server" onserverclick="OnGetResultButtonClicked" type="button" value="=" /></li>
            </ul>
        <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="ClearButton_Click" CssClass="btn btn-warning" />
    </div>
</asp:Content>
