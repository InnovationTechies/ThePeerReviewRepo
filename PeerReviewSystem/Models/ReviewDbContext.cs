﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
//using MySql.Data.Entity;
//using MySql.Data.EntityFramework;

namespace PeerReviewSystem.Models
{
    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ReviewDbContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ratings> Responses { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobRole> Roles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //This bit will create the store procedure automatically.
            modelBuilder.Entity<Review>().MapToStoredProcedures();
            modelBuilder.Entity<Project>().MapToStoredProcedures();
            modelBuilder.Entity<Questions>().MapToStoredProcedures();
            modelBuilder.Entity<Employee>().MapToStoredProcedures();
            modelBuilder.Entity<JobRole>().MapToStoredProcedures();


            base.OnModelCreating(modelBuilder);
        }
    }
}   