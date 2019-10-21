using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PeerReviewSystem.Models
{

    public class Review
    {
        [Key]
        public int reviewID { get; set; }
        
        [Display(Name = "ReviewDate")]
        public DateTime ReviewDate { get; set; }

        //Nav Properties
        public int projecctManagerID { get; set; }
        [ForeignKey("projecctManagerID")]
        public Employee ProjectLead { get; set; }

        public int reviewerID{ get; set; }
        [ForeignKey("reviewerID")]
        public Employee Reviewer { get; set; }

        public int revieweeID { get; set; }
        [ForeignKey("revieweeID")]
        public Employee Reviewee { get; set; }

        public int projectID { get; set; }
        [ForeignKey("projectID")]
        public Project Project { get; set; }

        public int questionID { get; set; }
        [ForeignKey("questionID")]
        public Questions Questions { get; set; }

        public int ratingID { get; set; }
        [ForeignKey("ratingID")]
        public Rating Rating { get; set; }

    }
}