<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaExpress.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <asp:Button ID="loginButton" runat="server" Text="Go to Order Manager" OnClick="loginButton_Click" CssClass="btn btn-sm btn-primary pull-right" />
        <div class="page-header">
          <h1>Pizza Express</h1>
          <p>Created by Miroslaw Debiec as per DevU tutorial.</p>
        </div>
        
        <div class="form-group">
          <label>Size:</label>
          <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalcCost">
              <asp:ListItem Text="Choose One..." Selected="True" Value="" />
              <asp:ListItem Text="Small &nbsp; (£12.00)" Value="Small" />
              <asp:ListItem Text="Medium &nbsp; (£14.00)" Value="Medium" />
              <asp:ListItem Text="Large &nbsp; (£16.00)" Value="Large" />
          </asp:DropDownList>
        </div>
        
        <div class="form-group">
          <label>Crust:</label>
          <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalcCost">
              <asp:ListItem Text="Choose One..." Selected="True" Value="" />
              <asp:ListItem Value="Regular">Regular &nbsp; (+£0.00)</asp:ListItem>
              <asp:ListItem Value="Thin">Thin &nbsp; (+£0.00)</asp:ListItem>
              <asp:ListItem Value="Thick">Thick &nbsp; (+£2.00)</asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalcCost"/> Sausage</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalcCost"/> Pepperoni</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalcCost"/> Onions</label></div>
        <div class="checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalcCost"/> Green Peppers</label></div>
        <h3>Deliver to: </h3>

        <div class="form-group"><label>Name:</label><asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox></div>
        <div class="form-group"><label>Address:</label><asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox></div>
        <div class="form-group"><label>Post Code:</label><asp:TextBox ID="postCodeTextBox" runat="server" CssClass="form-control"></asp:TextBox></div>
        <div class="form-group"><label>Phone:</label><asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox></div>
        <div class="form-group"><label>Email:</label><asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control"></asp:TextBox></div>
        <h3>Payment:</h3>

        <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" GroupName="PaymentGroup" Checked="true"/> Cash</label></div>
        <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="PaymentGroup" /> Credit</label></div>

        <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lg btn-primary" OnClick="orderButton_Click" />
        &nbsp;
        <strong><asp:Label ID="errorLabel" runat="server" Text="Label" Visible="false" CssClass="alert alert-danger"></asp:Label></strong>
        <p>&nbsp;</p>

        <h3>Total Cost: <asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>


    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
