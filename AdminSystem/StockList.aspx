<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 154px; top: 613px; position: absolute" Text="Clear Filter" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 104px; top: 481px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 653px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 177px; top: 481px; position: absolute" Text="Delete" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 11px; top: 549px; position: absolute; right: 1054px" Text="Enter a Supplier "></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 124px; top: 548px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 17px; top: 610px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" style="z-index: 1;  position: absolute; top: 615px; left: 306px;" Text="Statistics Page" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnReturnToMM" runat="server" OnClick="btnReturnToMM_Click" style="z-index: 1;  position: absolute; top: 616px; left: 479px;" Text="Return to Main Menu" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; position: absolute; top: 480px; left: 20px;" Text="Add" />
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 16px; top: 41px; position: absolute; height: 411px; width: 536px; right: 577px; bottom: 218px;" ></asp:ListBox>
    </form>
</body>
</html>
