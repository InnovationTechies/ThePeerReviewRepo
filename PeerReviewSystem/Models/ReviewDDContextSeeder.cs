using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{
    public class ReviewDDContextSeeder : DropCreateDatabaseAlways<ReviewDbContext>
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
                Role = "All"

            };
            Employee employee1 = new Employee()
            {

                Name = "Ray",
                Surname = "Finn",
                Role = "All"

            };
            Employee employee2 = new Employee()
            {

                Name = "Edwin",
                Surname = "Toi",
                Role = "All"

            };

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

            Answers answer = new Answers() {
                Rating = "Exceptional Performance"
            };
            Answers answer1 = new Answers()
            {
                Rating = "Full Performance"
            };
            Answers answer2 = new Answers()
            {
                Rating = "Not full Performance"
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

            context.Answer.Add(answer);
            context.Answer.Add(answer1);
            context.Answer.Add(answer2);


            base.Seed(context);
        }
    }
}