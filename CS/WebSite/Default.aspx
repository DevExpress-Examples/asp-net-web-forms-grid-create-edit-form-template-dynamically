<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.v15.1, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.v15.1,  Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" 
            AutoGenerateColumns="False" DataSourceID="AccessDataSource1" 
            KeyFieldName="CategoryID" onrowinserting="ASPxGridView1_RowInserting" 
            onrowupdating="ASPxGridView1_RowUpdating">
            <Columns>
                <dxwgv:GridViewCommandColumn VisibleIndex="0" ShowEditButton="True" ShowNewButton="True"/>
                <dxwgv:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" 
                    VisibleIndex="1">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="2">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
                </dxwgv:GridViewDataTextColumn>
            </Columns>
            <SettingsPager Visible="False">
            </SettingsPager>
        </dxwgv:ASPxGridView>
    
    </div>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/nwind.mdb" 
        DeleteCommand="DELETE FROM [Categories] WHERE [CategoryID] = ?" 
        InsertCommand="INSERT INTO [Categories] ([CategoryID], [CategoryName], [Description]) VALUES (?, ?, ?)" 
        SelectCommand="SELECT * FROM [Categories]" 
        UpdateCommand="UPDATE [Categories] SET [CategoryName] = ?, [Description] = ? WHERE [CategoryID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="CategoryID" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="CategoryName" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="CategoryID" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="CategoryID" Type="Int32" />
            <asp:Parameter Name="CategoryName" Type="String" />
            <asp:Parameter Name="Description" Type="String" />
        </InsertParameters>
    </asp:AccessDataSource>
    </form>
</body>
</html>
