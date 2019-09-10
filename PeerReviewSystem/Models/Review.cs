using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PeerReviewSystem.Models
{
    [Table("tblReview")]
    public class Review
    {
        [Key]
        public int reviewID { get; set; }
        [Display(Name = "ReviewDate")]
        public DateTime ReviewDate { get; set; }

        //Nav Properties

        [Display(Name = "ProjectLead")]
        public Employee ProjectLead { get; set; }

        [Display(Name = "Reviewer")]
        public Employee Reviewer { get; set; }

        [Display(Name = "Project")]
        public Project  Project{ get; set; }

        [Display(Name = "Reviewee")]
        public Employee Reviewee { get; set; }

        [Display(Name = "Questions")]
        public Questions Questions { get; set; }

        [Display(Name = "Rating")]
        public Response Rating { get; set; }

    }
}