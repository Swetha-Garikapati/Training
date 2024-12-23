<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productDetails.aspx.cs" Inherits="Assignment_1.productDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Products</h1>
<asp:DropDownList ID="product" runat="server" AutoPostBack="true" OnSelectedIndexChanged="product_SelectedIndexChanged">
<asp:ListItem Text="Select a product" Value="0" />
<asp:ListItem Text="Lunch Box" Value="1" />
<asp:ListItem Text="Bottle" Value="2" />
<asp:ListItem Text="Trolley" Value="3" />
<asp:ListItem Text="Bag" Value="4" />
</asp:DropDownList>
<br /><br />
<asp:Image ID="img" runat="server" CssClass="product-image" Visible="false" Width="200px" Height="200px" />
<br /><br />
<asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
<br /><br />
<asp:Label ID="price" runat="server" Text="Price: $" Visible="false" />
        </div>
    </form>
</body>
</html>
