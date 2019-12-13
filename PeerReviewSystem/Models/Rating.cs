using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{

    public class Ratings
    {
        //Scalar Properties
        [Key]
        public int rateID { get; set; }
        public string Rating { get; set; }

    }
}