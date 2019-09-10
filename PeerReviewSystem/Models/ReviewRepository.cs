using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
{
    
    public class ReviewRepository
    {
        public List<Review> GetReviews()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Reviews.Include("Reviewer").ToList();
        }
        public  List<Employee> GetEmployees()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Employees.ToList();
        }
        public  List<Questions> GetQuestions()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Questions.ToList();
        }
        public List<Project> GetProjects()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Projects.ToList();
        }
        public List<JobRole> GetJobRoles()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Roles.Include("Employees").ToList();
        }

    }
}