using PeerReviewSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeerReviewSystem
{
    public partial class frmAddRole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ReviewRepository reviewRepository = new ReviewRepository();
            JobRole role = new JobRole();

            role.Role = txtRole.Text;
            reviewRepository.InsertRole(role);
            Response.Redirect(Request.RawUrl);
        }
    }
}