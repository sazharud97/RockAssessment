<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SA-SmallGroupDetail.ascx.cs" Inherits="RockWeb.Blocks.Utility.SA_SmallGroupDetail" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title"><i class="fa fa-users"></i> Small Group Details</h1>
            </div>
            <div class="panel-body">
                <dl class="dl-horizontal">
                    <dt>Name</dt>
                    <dd><asp:Literal ID="lName" runat="server" /></dd>
                    <dt>Description</dt>
                    <dd><asp:Literal ID="lDescription" runat="server" /></dd>
                    <dt>Date Created</dt>
                    <dd><asp:Literal ID="lDateCreated" runat="server" /></dd>
                    <dt>Date Modified</dt>
                    <dd><asp:Literal ID="lDateModified" runat="server" /></dd>
                    <dt>Group Capacity</dt>
                    <dd><asp:Literal ID="lCapacity" runat="server" /></dd>
                </dl>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>