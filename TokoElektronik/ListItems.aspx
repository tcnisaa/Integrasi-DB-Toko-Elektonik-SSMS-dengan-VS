<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListItems.aspx.cs" Inherits="TokoElektronik.ListItems" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Toko Elektronik Orders</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="text-align:center; color:blue;">Kelompok 60_Shift 6</h1>
        <h2>Tambah Order</h2>
        <table>
            <tr>
                <td>Order ID :</td>
                <td><asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Customer Name :</td>
                <td><asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Quantity :</td>
                <td><asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Product ID :</td>
                <td><asp:TextBox ID="txtProductID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="CLEAR" OnClick="btnClear_Click" />
                </td>
            </tr>
        </table>

        <h3>Data Orders</h3>
        <asp:GridView ID="GridViewOrders" runat="server"></asp:GridView>
    </form>
</body>
</html>
