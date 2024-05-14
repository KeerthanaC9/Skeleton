<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblShoeId" runat="server" EnableTheming="True" style="z-index: 1; left: 13px; top: 41px; position: absolute" Text="Shoe ID" width="96px"></asp:Label>
        <asp:TextBox ID="txtShoeId" runat="server" style="z-index: 1; left: 122px; top: 39px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblShoeName" runat="server" style="z-index: 1; left: 13px; top: 77px; position: absolute; width: 96px; bottom: 580px" Text="Shoe Name"></asp:Label>
            <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 13px; top: 115px; position: absolute; width: 96px; margin-bottom: 0px; height: 21px;" Text="Supplier"></asp:Label>
            <asp:TextBox ID="txtSupplier" runat="server" style="z-index: 1; left: 119px; top: 118px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtShoeName" runat="server" style="z-index: 1; left: 121px; top: 79px; position: absolute; width: 121px;"></asp:TextBox>
        </p>
        
        <p>
            <asp:Label ID="lblShoeSize" runat="server" style="z-index: 1; left: 13px; top: 152px; position: absolute" Text="Shoe Size" width="96px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtShoeSize" runat="server" style="z-index: 1; left: 117px; top: 151px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblShoeColor" runat="server" style="z-index: 1; left: 13px; top: 183px; position: absolute" Text="Shoe Color" width="96px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 71px; top: 279px; position: absolute" Text="Available" />
            <asp:TextBox ID="txtShoeColor" runat="server" style="z-index: 1; left: 117px; top: 183px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblShoePrice" runat="server" style="z-index: 1; left: 12px; top: 211px; position: absolute" Text="Shoe Price" width="96px"></asp:Label>
            <asp:TextBox ID="txtShoePrice" runat="server" style="z-index: 1; left: 117px; top: 209px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 309px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtDateUpdated" runat="server" style="z-index: 1; left: 118px; top: 240px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDateUpdated" runat="server" style="z-index: 1; left: 11px; top: 243px; position: absolute; right: 1378px; height: 21px;" Text="Date Updated"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 343px; position: absolute; height: 26px" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 104px; top: 342px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
