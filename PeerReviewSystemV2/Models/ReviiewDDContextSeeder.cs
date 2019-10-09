using PeerReviewSystemV2.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeerReviewSystemV2.Models
{
    public class ReviiewDDContextSeeder:DropCreateDatabaseIfModelChanges<ReviewDbContext>
    {
        protected override void Seed(ReviewDbContext context)
        {
            Review review = new Review()
            {
                ReviewDate = DateTime.Now.Date,
                ProjectLead = new List<Employee>()
                {
                    new Employee ()
                    {
                        Name="Zizi",
                        Surname="Nzombane",
                        Role="Cinematographer"

                    }
                    //,

                    //new Employee ()
                    //{
                    //    Name="Ray",
                    //    Surname="Finn",
                    //    Role="Sound Engineer"

                    //},

                    // new Employee ()
                    //{
                    //    Name="Edwin",
                    //    Surname="Toi",
                    //    Role="Animator"
                    // }
                }
                //Project = new List<Project>()
                //{
                //    new Project()
                //    {
                //        StartDate=DateTime.Now.Date,
                //        EndDate=DateTime.Now.Date.AddMonths(6),
                //        Name="Kazi Bazibantu"
                //    },

                //    new Project()
                //    {
                //        StartDate=DateTime.Now.Date,
                //        EndDate=DateTime.Now.AddDays(3),
                //        Name="Unicef VR"
                //    },

                //    new Project()
                //    {
                //        StartDate=DateTime.Now.Date,
                //        EndDate=DateTime.Now.AddDays(2),
                //        Name="Sasol VR"
                //    }
                //}

            };
            context.Reviews.Add(review);

            base.Seed(context);
        }
    }
}