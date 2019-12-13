using System;

namespace PeerReviewSystem.Models
{
    public interface IReview
    {
        Project Project { get; set; }
        int projectID { get; set; }
        Employee ProjectLead { get; set; }
        int ProjectLeadID { get; set; }
        int questionID { get; set; }
        Questions Questions { get; set; }
        Ratings Rating { get; set; }
        int ratingID { get; set; }
        DateTime ReviewDate { get; set; }
        Employee Reviewee { get; set; }
        int revieweeID { get; set; }
        Employee Reviewer { get; set; }
        int reviewerID { get; set; }
        int reviewID { get; set; }
    }
}