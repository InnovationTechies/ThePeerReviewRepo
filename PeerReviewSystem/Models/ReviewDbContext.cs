using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PeerReviewSystem.Models
{
    public class ReviewDbContext: DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobRole> Roles { get; set; }

    }
}   