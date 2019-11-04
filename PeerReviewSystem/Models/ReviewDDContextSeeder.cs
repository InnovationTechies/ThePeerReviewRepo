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
            //JobRole jobRole = new JobRole()
            //{
            //    Role = "Animator"
            //};
            //JobRole jobRole1 = new JobRole()
            //{
            //    Role = "Graphic Designer"
            //};
            //JobRole jobRole2 = new JobRole()
            //{
            //    Role = "Editor"
            //};
            //JobRole jobRole3 = new JobRole()
            //{
            //    Role = "Sound"
            //};

            //context.Roles.Add(jobRole);
            //context.Roles.Add(jobRole1);
            //context.Roles.Add(jobRole2);
            //context.Roles.Add(jobRole3);

            //Project project = new Project()
            //{
            //    StartDate = DateTime.Now.Date,
            //    EndDate = DateTime.Now.Date.AddMonths(6),
            //    Name = "Kazi Bazibantu"
            //};
            //Project project1 = new Project()
            //{

            //    StartDate = DateTime.Now.Date,                                                                          
            //    EndDate = DateTime.Now.AddDays(2),
            //    Name = "Sasol VR"

            //};
            //Project project2 = new Project()
            //{

            //    StartDate = DateTime.Now.Date,
            //    EndDate = DateTime.Now.AddDays(3),
            //    Name = "Unicef VR"

            //};

            //Employee employee = new Employee() {

            //    Name = "Zizi",
            //    Surname = "Nzombane",
            //    RoleID = 3
            //};
            //Employee employee1 = new Employee()
            //{

            //    Name = "Ray",
            //    Surname = "Finn",
            //    RoleID = 4

            //};
            //Employee employee2 = new Employee()
            //{

            //    Name = "Edwin",
            //    Surname = "Toi",
            //    RoleID = 1

            //};

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Questions questionsRole1 = new Questions()
            //{
            //    Question = "Understanding the Project’s Vision.",
            //    RoleID = 1

            //};
            //Questions questionsRole2 = new Questions()
            //{
            //    Question = "Develops an animatic of the whole animation (Animatic).",
            //    RoleID = 1
            //};
            //Questions questionsRole3 = new Questions()
            //{
            //    Question = "Visual style.",
            //    RoleID = 1

            //};
            //Questions questionsRole4 = new Questions()
            //{
            //    Question = " Asset Creation.",
            //    RoleID = 1

            //};
            //Questions questionsRole5 = new Questions()
            //{
            //    Question = "Animation.",
            //    RoleID = 1

            //};

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Questions questionsRole6 = new Questions()
            //{
            //    Question = "Aligns the graphic elements designed with the chosen style.",
            //    RoleID = 2

            //};
            //Questions questionsRole7 = new Questions()
            //{
            //    Question = "Creating Graphic Elements for Video.",
            //    RoleID = 2

            //};
            //Questions questionsRole8 = new Questions()
            //{
            //    Question = "Creating Graphic Elements for Animation.",
            //    RoleID = 2

            //};
            //Questions questionsRole9 = new Questions()
            //{
            //    Question = "Focus on the General Design.",
            //    RoleID = 2

            //};

            //Rating answer = new Rating() {
            //    rating = "Exceptional Performance"
            //};
            //Rating answer1 = new Rating()
            //{
            //    rating = "Full Performance"
            //};
            //Rating answer2 = new Rating()
            //{
            //    rating = "Not full Performance"
            //};

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

            

            //context.Projects.Add(project);
            //context.Projects.Add(project1);
            //context.Projects.Add(project2);

            //context.Employees.Add(employee);
            //context.Employees.Add(employee1);
            //context.Employees.Add(employee2);

            //context.Responses.Add(answer);
            //context.Responses.Add(answer1);
            //context.Responses.Add(answer2);

            //context.Questions.Add(questionsRole1);
            //context.Questions.Add(questionsRole2);
            //context.Questions.Add(questionsRole3);
            //context.Questions.Add(questionsRole4);
            //context.Questions.Add(questionsRole5);

            //context.Questions.Add(questionsRole6);
            //context.Questions.Add(questionsRole7);
            //context.Questions.Add(questionsRole8);
            //context.Questions.Add(questionsRole9);

            base.Seed(context);
        }
    }
}