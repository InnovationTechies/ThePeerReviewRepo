using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{
    [Table("tblResponse")]
    public class Response
    {
        //Scalar Properties
        [Key]
        public int responseID { get; set; }
        public string Rating { get; set; }

        //Nav Properties
        public List<Review> Reviews { get; set; }
    }
}