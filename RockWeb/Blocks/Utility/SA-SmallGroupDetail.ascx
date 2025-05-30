<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SA-SmallGroupDetail.ascx.cs" Inherits="Blocks_Utility_SA_SmallGroupList" %>
<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-users"></i> Small Groups</h1>
            </div>
            <div class="panel-body">
                <Rock:Grid ID="gList" runat="server" AllowSorting="true" OnRowSelected="gList_RowSelected">
                    <Columns>
                        <%--Columns for every property specified by assignmen--%>
                        <Rock:RockBoundField DataField="Name" HeaderText="Group Name" SortExpression="Name" />
                        <Rock:RockBoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        <Rock:RockBoundField DataField="DateCreated" HeaderText="Date Created" SortExpression="DateCreated" />
                        <Rock:RockBoundField DataField="DateModified" HeaderText="Date Modified" SortExpression="DateModified" />
                        <Rock:RockBoundField DataField="GroupCapacity" HeaderText="Group Capacity" SortExpression="GroupCapacity" />
                    </Columns>
                </Rock:Grid>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
