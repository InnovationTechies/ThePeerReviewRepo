using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{

    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public int empID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }

        //Nav Properties

        //public Review Review { get; set; }
        //public List<Review> Reviews { get; set; }


    }
}