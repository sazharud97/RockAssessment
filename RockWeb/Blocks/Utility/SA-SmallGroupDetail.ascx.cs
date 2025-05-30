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
    public partial class SA_SmallGroupDetail : Rock.Web.UI.RockBlock
    {
        // Page parameter key for GroupId
        private static class PageParameterKey
        {
            public const string GroupId = "GroupId";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGroupDetails();
            }
        }

        private void ShowGroupDetails()
        {
            // Get the GroupId from the page parameter (passed from the list block)
            int groupId = int.Parse(PageParameter(PageParameterKey.GroupId));

            if (groupId == 0)
            {
                // No group selected, show nothing or a message
                pnlView.Visible = false;
                return;
            }

            using (var rockContext = new RockContext())
            {
                var group = new GroupService(rockContext)
                    .Queryable()
                    .Where(g => g.Id == groupId)
                    .Select(g => new
                    {
                        g.Name,
                        g.Description,
                        g.CreatedDateTime,
                        g.ModifiedDateTime,
                        g.GroupCapacity
                    })
                    .FirstOrDefault();

                if (group == null)
                {
                    pnlView.Visible =  false;
                    return;
                }

                lName.Text = group.Name;
                lDescription.Text = group.Description;
                lDateCreated.Text = group.CreatedDateTime?.ToString("yyyy-MM-dd") ?? "N/A";
                lDateModified.Text = group.ModifiedDateTime?.ToString("yyyy-MM-dd") ?? "N/A";
                lCapacity.Text = group.GroupCapacity.HasValue ? group.GroupCapacity.Value.ToString() : "N/A";
            }
        }
    }
}