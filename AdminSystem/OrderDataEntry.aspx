<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 171px; top: 39px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 27px; top: 34px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 26px; top: 64px; position: absolute; width: 57px;" Text="Customer ID" height="19px"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 28px; top: 107px; position: absolute; width: 57px;" Text="Order Date" height="19px"></asp:Label>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 27px; top: 143px; position: absolute; width: 57px;" Text="Product ID" height="19px"></asp:Label>
        <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 26px; top: 178px; position: absolute; width: 57px;" Text="Total Price" height="19px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 171px; top: 219px; position: absolute" Text="Order Active" />
        <asp:CheckBox ID="chkDelivered" runat="server" style="z-index: 1; left: 171px; top: 247px; position: absolute" Text="OrderDelivered" />
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 171px; top: 72px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 171px; top: 111px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 171px; top: 148px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 26px; top: 287px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" style="z-index: 1; left: 80px; top: 339px; position: absolute" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 143px; top: 339px; position: absolute" Text="Cancel" />
        <p>
            <asp:Button ID="btnFind" runat="server" Height="31px" OnClick="btnFind_Click" style="margin-left: 349px" Text="Find" Width="74px" />
        </p>
        <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 171px; top: 185px; position: absolute; margin-bottom: 10px;" ></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
