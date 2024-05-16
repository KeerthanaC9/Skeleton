<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" Text="ID" width="136px"></asp:Label>&nbsp;&nbsp; <asp:TextBox runat="server" ID="txtCustomerId" height="28px" width="152px"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Label runat="server" Text="Name" ID="lblCustomerName" height="19px" width="136px"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtCustomerName" height="28px" width="152px"></asp:TextBox>
            &nbsp;<br />
        </div>
        <div>
            <asp:Label runat="server" Text="Email" ID="lblCustomerEmail" height="19px" width="136px"></asp:Label>&nbsp;&nbsp; <asp:TextBox runat="server" OnTextChanged="Unnamed2_TextChanged" ID="txtCustomerEmail" height="28px" width="152px"></asp:TextBox>
            <br />
            &nbsp;</div>
        <div>&nbsp;<asp:Label ID="lblCustomerDob" runat="server" height="19px" Text="Date Of Birth" width="136px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtCustomerDob" runat="server" height="27px" width="152px"></asp:TextBox>
            <br />
        </div>
        <asp:Label ID="lblCustomerPhoneNumber" runat="server" height="19px" Text="Phone Number" width="136px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerPhoneNumber" runat="server" height="28px" width="152px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerAddress" runat="server" height="19px" Text="Address" width="136px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerAddress" runat="server" height="28px" width="152px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="width: 33px" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
    </form>
</body>
</html>
