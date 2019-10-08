using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeerReviewSystemV2.Controllers
{

    /// <summary>
    /// Repo will have all the edit code
    /// </summary>
    public class ReviewRepository
    {
        ReviewDbContext reviewDbContext = new ReviewDbContext();

        public void InsertReview(Review review)
        {
            reviewDbContext.Reviews.Add(review);
            reviewDbContext.SaveChanges();
        }

        public void UpdateReview(Review review)
        {
            Review reviewToUpdate= reviewDbContext.Reviews.FirstOrDefault(x => x.reviewID == review.reviewID);
            reviewToUpdate.ProjectLead = review.ProjectLead;
            //reviewToUpdate.Project = review.Project;
            reviewToUpdate.ReviewDate = review.ReviewDate;
            //reviewToUpdate.Reviewer = review.Reviewer;
            //reviewToUpdate.Reviewee = review.Reviewee;
            //reviewToUpdate.Questions = review.Questions;
            //reviewToUpdate.Rating = review.Rating;

            
            reviewDbContext.SaveChanges();
        }

        public void DeleteReview(Review review)
        {
            Review reviewToDelete = reviewDbContext.Reviews.FirstOrDefault(x => x.reviewID == review.reviewID);
            reviewDbContext.Reviews.Remove(reviewToDelete);
            reviewDbContext.SaveChanges();
        }

        public List<Review> GetReviews()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Reviews.ToList();
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