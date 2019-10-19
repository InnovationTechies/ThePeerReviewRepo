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
                        project = drpProject.SelectedItem.Text,
                        ProjectManager = drpProjectLead.SelectedItem.Text,
                        ReviewDate = DateTime.Today,
                        reviewer = dropReviewer.SelectedItem.Text,
                        reviewee = drpReviewee.SelectedItem.Text,
                        question = row.Cells[1].Text,
                        rating= dropDown.SelectedItem.Text

                    };

                    repository.InsertReview(review);

                    
                }
            }
        }

        protected void drpReviewee_SelectedIndexChanged(object sender, EventArgs e)
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