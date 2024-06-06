<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 19px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 397px; top: 40px; position: absolute" Text="Main Menu"></asp:Label>
        <p>
            <asp:Button ID="btnStocks" runat="server" OnClick="btnStocks_Click" style="z-index: 1; left: 648px; top: 78px; position: absolute" Text="Stocks" />
        </p>
        <p>
            <asp:Button ID="btnStaff" runat="server" Style="z-index: 1; left: 171px; top: 76px; position: absolute" Text="Staff" OnClick="btnStaff_Click" />
        </p>
        <p>
            <asp:Button ID="btnCustomers" runat="server" Style="z-index: 1; left: 291px; top: 77px; position: absolute" Text="Customers" OnClick="btnCustomers_Click" />
        </p>
        <asp:Button ID="btnOrders" runat="server" Style="z-index: 1; left: 491px; top: 77px; position: absolute" Text="Orders" OnClick="btnOrders_Click" />
    </form>
</body>
</html>
