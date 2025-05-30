using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

using Rock;
using Rock.Data;
using Rock.Model;
using Rock.Web.Cache;
using Rock.Web.UI.Controls;
using Rock.Attribute;
using Rock.Web.UI;
using Grpc.Core;

namespace RockWeb.Blocks.Utility
{
    public partial class SA_SmallGroupList : Rock.Web.UI.RockBlock
    {
        // found ID in groupType file
        private static readonly Guid SmallGroupTypeGuid = new Guid("50FCFB30-F51A-49DF-86F4-2B176EA1820B");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        //Query DB and show the list of small groups
        private void BindGrid()
        {
            using (var rockContext = new RockContext())
            {
                // Query for active small groups of the specified type
                var groups = new GroupService(rockContext)
                    .Queryable()
                    .Where(g => g.GroupType.Guid == SmallGroupTypeGuid && g.IsActive && !g.IsArchived)
                    .Select(g => new
                    {
                        g.Id,
                        g.Name,
                        g.Description
                    })
                    .ToList();

                gList.DataSource = groups;
                gList.DataBind();
            }
        }

        protected void gList_RowSelected(object sender, Rock.Web.UI.Controls.RowEventArgs e)
        {
            var pageParams = new System.Collections.Generic.Dictionary<string, string>
            {
                { "GroupId", e.RowKeyId.ToString() }
            };
            NavigateToLinkedPage("SA-SmallGroupDetail", pageParams);
        }
    }
}