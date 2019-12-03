using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeerReviewSystem.Models
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
            reviewToUpdate.ProjectLeadID = review.ProjectLeadID;
            reviewToUpdate.projectID = review.projectID;
            reviewToUpdate.ReviewDate = review.ReviewDate;
            reviewToUpdate.reviewerID= review.revieweeID;
            reviewToUpdate.revieweeID = review.revieweeID;
            reviewToUpdate.questionID = review.questionID;
            reviewToUpdate.ratingID = review.ratingID;

            reviewDbContext.SaveChanges();
        }

        public void DeleteReview(Review review)
        {
            Review reviewToDelete = reviewDbContext.Reviews.FirstOrDefault(x => x.reviewID == review.reviewID);
            reviewDbContext.Reviews.Remove(reviewToDelete);
            reviewDbContext.SaveChanges();
        }

        public IEnumerable<Review> GetReviews()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Reviews.ToList();
        }

        public IEnumerable<ReviewAll> uspGetReviews()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();

            IEnumerable<ReviewAll> products =
             reviewDbContext.Database.SqlQuery<ReviewAll>("dbo.Review_Select");

            return products;
        }


        public IEnumerable<Employee> GetEmployees()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Employees.ToList();
        }


        /// <summary>
        /// Get the employee question by name
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        public IEnumerable<Questions> GetQuestionsByEmployee(int RoleID)
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Questions.Where(x=> x.RoleID== RoleID || x.RoleID==5 ).ToList();
        }

        public IEnumerable<Questions> GetQuestions()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Questions.ToList();
        }
        public IEnumerable<Project> GetProjects()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Projects.ToList();
        }

        public void InsertRole (JobRole jobRole)
        {
            reviewDbContext.Roles.Add(jobRole);
            reviewDbContext.SaveChanges();
        }

        public void UpdatetRole(JobRole jobRole)
        {
            JobRole jobRoleToUpdate = reviewDbContext.Roles.FirstOrDefault(x => x.roleID == jobRole.roleID);
            jobRoleToUpdate.Role= jobRole.Role;
            reviewDbContext.SaveChanges();
        }


        public IEnumerable<JobRole> GetJobRoles()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Roles.ToList();
        }
        public IEnumerable<Rating> GetAnswerRating()
        {
            ReviewDbContext reviewDbContext = new ReviewDbContext();
            return reviewDbContext.Responses.ToList();
        }


    }
}