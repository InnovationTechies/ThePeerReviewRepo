using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeerReviewSystemV2.Controllers
{
    public class Review
    {
        [Key]
        public int reviewID { get; set; }
        [Display(Name = "ReviewDate")]
        public DateTime ReviewDate { get; set; }

        //Nav Properties
        //[Column("ProjectLead")]
        [ForeignKey("empID")]
        public List<Employee> Lead { get; set; }
 
        //[Column("Project")]
        //[ForeignKey("projectID")]
        //public List<Project> Project { get; set; }

        //[Column("Reviewer")]
        //[ForeignKey("empID")]
        //public List<Employee> Reviewer { get; set; }

        //[Column("Reviewee")]
        //[ForeignKey("empID")]
        //public List<Employee> Reviewee { get; set; }

        //[Column("Question")]
        //[ForeignKey("questionID")]
        //public List<Questions> Questions { get; set; }

        //[Column("Rating")]
        //[ForeignKey("rateID")]
        //public List<Rating> Rating { get; set; }

    }
}