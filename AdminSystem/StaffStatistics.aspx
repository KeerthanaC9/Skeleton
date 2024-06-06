<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffStatistics.aspx.cs" Inherits="StaffStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStTitle" runat="server" Font-Size="X-Large" style="z-index: 1; left: 30px; top: 52px; position: absolute" Text="Statistics Page"></asp:Label>
        <asp:Label ID="lblStStaffSalary" runat="server" style="z-index: 1; left: 40px; top: 112px; position: absolute" Text="Staff List - Grouped By Staff Salary"></asp:Label>
        <asp:GridView ID="GridViewStGroupBySalary" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" style="z-index: 1; left: 30px; top: 152px; position: absolute; height: 180px; width: 289px" OnSelectedIndexChanged="GridViewStGroupBySalary_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:Label ID="lblStDateJoined" runat="server" style="z-index: 1; left: 40px; top: 352px; position: absolute" Text="Staff List - Grouped By Date Joined"></asp:Label>
        <asp:GridView ID="GridViewStGroupByDateJoined" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" style="z-index: 1; left: 30px; top: 392px; position: absolute; height: 180px; width: 289px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:Button ID="btnPreviousPage" runat="server" OnClick="btnPreviousPage_Click" style="z-index: 1; left: 20px; top: 622px; position: absolute" Text="Back To Previous Page" />
    </form>
</body>
</html>
