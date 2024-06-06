<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDeleteRecord" runat="server" style="z-index: 1; left: 131px; top: 214px; position: absolute; height: 48px; width: 572px;" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 182px; top: 249px; position: absolute; height: 28px; width: 51px;" Text="Yes" OnClick="btnYes_Click" />
        </p>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 266px; top: 249px; position: absolute; height: 28px; width: 51px;" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
