using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{
    public class ReviewAll:IReview
    {
        public ReviewAll()
        {
        }

        //public int reviewID { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Question { get; set; }
        public string rating { get; set; }

        public Rating Rating { get; set; }
        public Project Project { get ; set; }
        public int projectID { get; set ; }
        public Employee ProjectLead { get; set; }
        public int ProjectLeadID { get; set; }
        public int questionID { get; set; }
        public Questions Questions { get; set; }
        public int ratingID { get; set; }
        public Employee Reviewee { get; set; }
        public int revieweeID { get; set; }
        public Employee Reviewer { get; set; }
        public int reviewerID { get; set; }
        public int reviewID { get; set; }
    }
}