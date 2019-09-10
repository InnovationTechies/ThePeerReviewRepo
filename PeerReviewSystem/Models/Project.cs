using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{

    [Table("tblProject")]
    public class Project
    {
        [Key]
        public int projectID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        //Nav Properties
        public List<Review> Reviews { get; set; }
    }
}