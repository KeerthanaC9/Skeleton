<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnStaffRoleApplyFilter" runat="server" OnClick="btnStaffRoleApplyFilter_Click" style="z-index: 1; left: 30px; top: 635px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnStaffRoleClearFilter" runat="server" OnClick="btnStaffRoleClearFilter_Click" style="z-index: 1; left: 240px; top: 635px; position: absolute" Text="Clear Filter" />
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 780px; top: 635px; position: absolute" Text="Return to Main Menu" />
            <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 442px; width: 697px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 500px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 95px; top: 500px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 799px; top: 391px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 180px; top: 500px; position: absolute" Text="Delete" />
        <asp:Label ID="lblStaffRoleFilter" runat="server" style="z-index: 1; left: 10px; top: 574px; position: absolute" Text="Enter a Staff Role"></asp:Label>
        <asp:TextBox ID="txtStaffRoleFilter" runat="server" style="z-index: 1; left: 240px; top: 572px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnStPage" runat="server" OnClick="btnStPage_Click" style="z-index: 1; left: 470px; top: 636px; position: absolute" Text="Statistics Page" />
    </form>
</body>
</html>
