using PeerReviewSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeerReviewSystem
{
    public partial class _Default : Page
    {
        public string role { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        //protected void drpReviewee_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    role = drpReviewee.SelectedItem.Value;
        //    ReviewRepository reviewRepository = new ReviewRepository();
        //    grdViewQuestions.DataSource = reviewRepository.GetQuestions();

        //}
    }
}