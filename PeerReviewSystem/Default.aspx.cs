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
        /// Save review by reviewwer into review table
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
                        projectID = int.Parse( drpProject.SelectedValue),
                        ProjectLeadID = int.Parse( drpProjectLead.SelectedValue),
                        ReviewDate = DateTime.Today,
                        reviewerID = int.Parse(dropReviewer.SelectedValue),
                        revieweeID = int.Parse(drpReviewee.SelectedValue),
                        questionID = int.Parse(row.Cells[2].Text),
                        ratingID= int.Parse(dropDown.SelectedValue)
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



        //protected void drpReviewee_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    role = drpReviewee.SelectedItem.Value;
        //    ReviewRepository reviewRepository = new ReviewRepository();
        //    grdViewQuestions.DataSource = reviewRepository.GetQuestions();

        //}
    }
}