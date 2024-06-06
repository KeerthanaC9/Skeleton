<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockStatistics.aspx.cs" Inherits="StockStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridViewStGroupByShoeName" runat="server" style="z-index: 1; left: 577px; top: 137px; position: absolute; height: 133px; width: 187px" OnSelectedIndexChanged="GridViewStGroupByShoeName_SelectedIndexChanged">
        </asp:GridView>
        <asp:GridView ID="GridViewStGroupByDateUpdated" runat="server" style="z-index: 1; left: 582px; top: 374px; position: absolute; height: 133px; width: 187px" OnSelectedIndexChanged="GridViewStGroupByDateUpdated_SelectedIndexChanged">
        </asp:GridView>
        <asp:Label ID="lblStatisticsPage" runat="server" style="z-index: 1; left: 616px; top: 44px; position: absolute; font-weight: 700;" Text="Statistics Page"></asp:Label>
        <asp:Label ID="lblGroupedByShoeName" runat="server" style="z-index: 1; left: 19px; top: 152px; position: absolute" Text="Stock List - Grouped by Shoe Name"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblGroupedByDateUpdated" runat="server" style="z-index: 1; left: 24px; top: 387px; position: absolute" Text="Stock List - Grouped by Date Updated"></asp:Label>
        </p>
        <asp:Button ID="btnBackToPreviousPage" runat="server" OnClick="btnBackToPreviousPage_Click" style="z-index: 1; left: 34px; top: 537px; position: absolute" Text="Back to Previous Page" />
    </form>
</body>
</html>
