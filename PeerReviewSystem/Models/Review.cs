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
        public string ProjectManager { get; set; }
        [Column("ProjectManager")]
        [ForeignKey("empID")]
        public IEnumerable<Employee> ProjectLead { get; set; }

        public string reviewer{ get; set; }
        [Column("Reviewer")]
        [ForeignKey("empID")]
        public IEnumerable<Employee> Reviewer { get; set; }

        public string project { get; set; }
        [Column("Project")]
        [ForeignKey("projectID")]
        public IEnumerable<Project> Project { get; set; }

        public string reviewee { get; set; }
        [Column("Reviewee")]
        [ForeignKey("empID")]
        public IEnumerable<Employee> Reviewee { get; set; }

        public string question { get; set; }
        [Column("Question")]
        [ForeignKey("questionID")]
        public IEnumerable<Questions> Questions { get; set; }

        public string rating { get; set; }
        [Column("Rating")]
        [ForeignKey("rateID")]
        public IEnumerable<Rating> Rating { get; set; }

    }
}