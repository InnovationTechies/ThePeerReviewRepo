using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{
    public class Employee
    {
        [Key]
        public int empID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int RoleID { get; set; }
        public JobRole JobRole { get; set; }
                                           
        //Nav Properties

        // public Review Review { get; set; }
        //public List<Review> Reviews { get; set; }


    }
}