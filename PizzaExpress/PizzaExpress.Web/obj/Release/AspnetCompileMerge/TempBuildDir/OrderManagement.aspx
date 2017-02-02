<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="PizzaExpress.Web.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
    <div class="page-header">
    <h1>Order Manager</h1>
    </div>
    <div class="form-group">
    <asp:GridView ID="ordersGridView" runat="server" CssClass="table" OnRowCommand="ordersGridView_RowCommand">
        <Columns>
            <asp:ButtonField Text="Complete" />
        </Columns>
        </asp:GridView>
    </div>
    <asp:Button ID="orderButton" runat="server" Text="Make Order" OnClick="orderButton_Click" CssClass="btn btn-lg btn-primary" />
    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
