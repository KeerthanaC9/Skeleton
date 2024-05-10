<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" Text="ID"></asp:Label><asp:TextBox runat="server" ID="txtCustomerId"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" Text="Name" ID="lblCustomerName"></asp:Label><asp:TextBox runat="server" ID="txtCustomerName"></asp:TextBox>&nbsp;</div>
        <div>
            <asp:Label runat="server" Text="Email" ID="lblCustomerEmail"></asp:Label><asp:TextBox runat="server" OnTextChanged="Unnamed2_TextChanged" ID="txtCustomerEmail"></asp:TextBox>&nbsp;</div>
        <div>&nbsp;</div>
    </form>
</body>
</html>
