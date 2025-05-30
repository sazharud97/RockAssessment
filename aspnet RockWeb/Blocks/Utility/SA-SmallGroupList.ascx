<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SA-SmallGroupList.ascx.cs" Inherits="RockWeb.Blocks.Utility.SA_SmallGroupList" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-users"></i> Small Groups</h1>
            </div>
            <div class="panel-body">
                <Rock:Grid ID="gList" runat="server" AllowSorting="true" OnRowSelected="gList_RowSelected">
                    <Columns>
                        <Rock:RockBoundField DataField="Name" HeaderText="Group Name" SortExpression="Name" />
                        <Rock:RockBoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    </Columns>
                </Rock:Grid>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>