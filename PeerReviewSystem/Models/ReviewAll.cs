using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{
    public class ReviewAll
    {
        public DateTime ReviewDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Question { get; set; }
        public string rating { get; set; }

    }
}