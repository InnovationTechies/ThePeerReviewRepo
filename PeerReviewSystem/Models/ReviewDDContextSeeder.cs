using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{
    /// <summary>
    /// Seeder contains Test data
    /// </summary>
    public class ReviewDDContextSeeder : DropCreateDatabaseIfModelChanges<ReviewDbContext>
    {
        protected override void Seed(ReviewDbContext context)
        {
            Project project = new Project()
            {

                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddMonths(6),
                Name = "Kazi Bazibantu"

            };
            Project project1 = new Project()
            {

                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.AddDays(2),
                Name = "Sasol VR"

            };
            Project project2 = new Project()
            {

                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.AddDays(3),
                Name = "Unicef VR"

            };

            Employee employee = new Employee() {

                Name = "Zizi",
                Surname = "Nzombane",
                Role = "Graphic Designer"

            };
            Employee employee1 = new Employee()
            {

                Name = "Ray",
                Surname = "Finn",
                Role = "Animator"

            };
            Employee employee2 = new Employee()
            {

                Name = "Edwin",
                Surname = "Toi",
                Role = "Animator"

            };

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            Questions questionsRole1 = new Questions()
            {
                Question = "Understanding the Project’s Vision.",
                Role = "Animator"

            };
            Questions questionsRole2 = new Questions()
            {
                Question = "Develops an animatic of the whole animation (Animatic).",
                Role = "Animator"

            };
            Questions questionsRole3 = new Questions()
            {
                Question = "Visual style.",
                Role = "Animator"

            };
            Questions questionsRole4 = new Questions()
            {
                Question = " Asset Creation.",
                Role = "Animator"

            };

            Questions questionsRole5 = new Questions()
            {
                Question = "Animation.",
                Role = "Animator"

            };

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Questions questionsRole6 = new Questions()
            {
                Question = "Aligns the graphic elements designed with the chosen style.",
                Role = "Graphic Designer"

            };
            Questions questionsRole7 = new Questions()
            {
                Question = "Creating Graphic Elements for Video.",
                Role = "Graphic Designer"

            };
            Questions questionsRole8 = new Questions()
            {
                Question = "Creating Graphic Elements for Animation.",
                Role = "Graphic Designer"

            };
            Questions questionsRole9 = new Questions()
            {
                Question = "Focus on the General Design.",
                Role = "Graphic Designer"

            };

            Rating answer = new Rating() {
                rating = "Exceptional Performance"
            };
            Rating answer1 = new Rating()
            {
                rating = "Full Performance"
            };
            Rating answer2 = new Rating()
            {
                rating = "Not full Performance"
            };

            //Exceptional Performance
            //Full Performance
            //Not full Performance

            //Review review = new Review()
            //{
            //    ReviewDate = DateTime.Now.Date,
            //    //ProjectLead = new List<Employee>()
            //    //{
            //    //    new Employee ()
            //    //    {
            //    //        Name="Zizi",
            //    //        Surname="Nzombane",
            //    //        Role="Cinematographer"

            //    //    }
            //        //,

            //        //new Employee ()
            //        //{
            //        //    Name="Ray",
            //        //    Surname="Finn",
            //        //    Role="Sound Engineer"

            //        //},

            //        // new Employee ()
            //        //{
            //        //    Name="Edwin",
            //        //    Surname="Toi",
            //        //    Role="Animator"
            //        // }
            //   // }
            //    //Project = new List<Project>()
            //    //{
            //    //    new Project()
            //    //    {
            //    //        StartDate=DateTime.Now.Date,
            //    //        EndDate=DateTime.Now.Date.AddMonths(6),
            //    //        Name="Kazi Bazibantu"
            //    //    },

            //    //    new Project()
            //    //    {
            //    //        StartDate=DateTime.Now.Date,
            //    //        EndDate=DateTime.Now.AddDays(3),
            //    //        Name="Unicef VR"
            //    //    },

            //    //    new Project()
            //    //    {
            //    //        StartDate=DateTime.Now.Date,
            //    //        EndDate=DateTime.Now.AddDays(2),
            //    //        Name="Sasol VR"
            //    //    }
            //    //}

            //};


            context.Projects.Add(project);
            context.Projects.Add(project1);
            context.Projects.Add(project2);

            context.Employees.Add(employee);
            context.Employees.Add(employee1);
            context.Employees.Add(employee2);

            context.Responses.Add(answer);
            context.Responses.Add(answer1);
            context.Responses.Add(answer2);

            context.Questions.Add(questionsRole1);
            context.Questions.Add(questionsRole2);
            context.Questions.Add(questionsRole3);
            context.Questions.Add(questionsRole4);
            context.Questions.Add(questionsRole5);

            context.Questions.Add(questionsRole6);
            context.Questions.Add(questionsRole7);
            context.Questions.Add(questionsRole8);
            context.Questions.Add(questionsRole9);

            base.Seed(context);
        }
    }
}