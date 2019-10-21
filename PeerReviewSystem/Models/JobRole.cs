using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{

    public class JobRole
    {
        [Key]
        public int roleID { get; set; }
        public string Role { get; set; }

        //Nav Properties
        //public List<Employee> Employees { get; set; }
        //public Review Review { get; set; }



    }
}