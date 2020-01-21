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

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Save Review by Reviewwer into review table db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSaveReview_Click(object sender, EventArgs e)
        {
            ReviewRepository repository = new ReviewRepository();
            Review review;

            foreach (GridViewRow row in grdRevQuestion.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    DropDownList dropDown = (DropDownList)row.FindControl("drpRating");
                    //Your other code
                    review = new Review()
                    {
                        projectID = Convert.ToInt32(drpProject.SelectedValue),
                        ProjectLeadID =Convert.ToInt32( drpProjectLead.SelectedValue),
                        ReviewDate = DateTime.Today,
                        reviewerID = Convert.ToInt32(dropReviewer.SelectedValue),
                        revieweeID = Convert.ToInt32(drpReviewee.SelectedValue),
                        questionID = Convert.ToInt32(row.Cells[2].Text),
                        ratingID= Convert.ToInt32(dropDown.SelectedValue)
                    };

                    repository.InsertReview(review);
                    
                }
            }
        }

        protected void drpReviewee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdReview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}