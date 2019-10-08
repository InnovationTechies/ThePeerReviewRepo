using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystemV2.Controllers
{
    public class Rating
    {
        //Scalar Properties
        [Key]
        public int rateID { get; set; }
        public string rating { get; set; }

        //Nav Properties
        public Review Review { get; set; }
        //public List<Review> Reviews { get; set; }
        //public Review Review { get; set; }

    }
}