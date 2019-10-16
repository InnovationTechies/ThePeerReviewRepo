﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{

    public class Questions
    {
        [Key]
        public int questionID { get; set; }
        public string Question { get; set; }
        public string Role { get; set; }

        //Nav Properties
        //public Review Review { get; set; }
        //public List<Review> Reviews { get; set; }


    }
}