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
        public virtual Employee ProjectLead { get; set; }

        public int reviewerID{ get; set; }
        public virtual Employee Reviewer { get; set; }

        public int revieweeID { get; set; }
        public virtual Employee Reviewee { get; set; }

        public int projectID { get; set; }
        public virtual Project Project { get; set; }

        public int questionID { get; set; }
        public virtual Questions Questions { get; set; }

        public int ratingID { get; set; }
        public virtual Rating Rating { get; set; }

    }
}