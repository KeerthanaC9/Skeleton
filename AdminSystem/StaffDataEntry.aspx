<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Staff ID" width="79px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 132px; top: 34px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 132px; top: 74px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 10px; top: 74px; position: absolute" Text="Staff Name" width="79px"></asp:Label>
        <asp:Button ID="btnFind" style="z-index: 1; left: 376px; top: 34px; position: absolute" runat="server" Text="Find" OnClick="btnFind_Click" />
        <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 10px; top: 114px; position: absolute" Text="Staff Role" width="79px"></asp:Label>
        <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 132px; top: 114px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 10px; top: 154px; position: absolute" Text="Staff Salary" width="79px"></asp:Label>
        <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 132px; top: 154px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffJobTitle" runat="server" style="z-index: 1; left: 10px; top: 194px; position: absolute; width: 87px;" Text="Staff Job Title"></asp:Label>
        <asp:TextBox ID="txtStaffJobTitle" runat="server" style="z-index: 1; left: 132px; top: 194px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 10px; top: 234px; position: absolute; width: 79px;" Text="Date Joined"></asp:Label>
        <asp:TextBox ID="txtDateJoined" runat="server" style="z-index: 1; left: 131px; top: 234px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 274px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 324px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 120px; top: 324px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
