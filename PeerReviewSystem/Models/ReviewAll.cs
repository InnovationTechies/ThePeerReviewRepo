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

        public Rating Rating { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Project Project { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int projectID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Employee ProjectLead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ProjectLeadID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int questionID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Questions Questions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ratingID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Employee Reviewee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int revieweeID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Employee Reviewer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int reviewerID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int reviewID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}