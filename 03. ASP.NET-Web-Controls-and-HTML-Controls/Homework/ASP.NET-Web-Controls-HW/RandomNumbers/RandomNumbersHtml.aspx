<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbersHtml.aspx.cs" Inherits="WebControlsHomework.RandomNumbersHtml" %>

<%--No asp: tags here! Thats why looks lika a master page :)--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./Content/bootstrap.css" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a runat="server" href="~/">Home</a></li>
                    <li><a runat="server" href="~/RandomNumbersWeb">Random Numbers Web</a></li>
                    <li><a runat="server" href="~/RandomNumbersHtml">Random Numbers Html</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        <div class="jumbotron">
            <form id="mainForm" runat="server">
                <label id="minNumberLabel" for="minNumberInput" runat="server">Enter min number</label>
                <input type="number" min="0" max="10000000" name="minNumberInput" id="minNumberInput" value="10" runat="server" />
                <hr />
                <label id="maxNumberLabel" for="maxNumberInput" runat="server">Enter max number</label>
                <input type="number" min="0" max="10000000" name="maxNumberInput" id="maxNumberInput" value="100" runat="server" />
                <hr />
                <input type="submit" value="Generate random number" runat="server" class="btn btn-success" onserverclick="OnSubmitButton_Click" />
                <hr />
                <div id="randomNumberContainer" runat="server"></div>
            </form>
        </div>
    </div>
</body>
</html>
