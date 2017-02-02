<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="PizzaExpress.Web.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {position:absolute; top:45%; left:45%;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
          <div class="center">
            <h1>Success!</h1>
            <asp:Button ID="newOrderButton" runat="server" Text="Another Order" CssClass="btn btn-lg btn-default" OnClick="newOrderButton_Click" />
          </div>
    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
