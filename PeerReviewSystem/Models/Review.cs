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
        [ForeignKey("ProjectLead")]
        public int projecctManagerID { get; set; }
        public virtual Employee ProjectLead { get; set; }

        [ForeignKey("Reviewer")]
        public int reviewerID{ get; set; }
        public virtual Employee Reviewer { get; set; }

        [ForeignKey("Reviewee")]
        public int revieweeID { get; set; }
        public virtual Employee Reviewee { get; set; }

        [ForeignKey("Project")]
        public int projectID { get; set; }
        public virtual Project Project { get; set; }

        [ForeignKey("Questions")]
        public int questionID { get; set; }
        public virtual Questions Questions { get; set; }

        [ForeignKey("Rating")]
        public int ratingID { get; set; }
        public virtual Rating Rating { get; set; }

    }
}