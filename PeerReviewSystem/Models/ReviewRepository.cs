using PeerReviewSystemV2.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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

        public void UpdateQuestion(Questions questions)
        {
            Questions questionsToUpdate = reviewDbContext.Questions.FirstOrDefault(x => x.questionID == questions.questionID);
            questionsToUpdate.Question = questions.Question;
            questionsToUpdate.Role = questions.Role;
            questionsToUpdate.RoleID = questions.RoleID;
            
            reviewDbContext.SaveChanges();
        }

        public int DeleteQuestion(Questions questions)
        {
            Questions questionsToDelete = reviewDbContext.Questions.FirstOrDefault(x => x.questionID == questions.questionID);
            reviewDbContext.Questions.Remove(questionsToDelete);

            return reviewDbContext.SaveChanges();
        }

        internal void InsertQuestion(Questions questions)
        {
            reviewDbContext.Questions.Add(questions);
            reviewDbContext.SaveChanges();
        }

        public void DeleteReview(Review review)
        {
            Review reviewToDelete = reviewDbContext.Reviews.FirstOrDefault(x => x.reviewID == review.reviewID) ;
            reviewDbContext.Reviews.Remove(reviewToDelete);
            reviewDbContext.SaveChanges();
        }

        public IEnumerable<Review> GetReviews()
        {
            return reviewDbContext.Reviews.ToList();
        }

        public IEnumerable<ReviewAll> uspGetReviews()
        {
            IEnumerable<ReviewAll> products = reviewDbContext.Database.SqlQuery<ReviewAll>("dbo.Review_Select");

            return products.ToList();

        }

        public IEnumerable<ReviewAll> UspGetReviewsEmployee(int empID)
        {
            IEnumerable<ReviewAll> result;
            using (var context = new ReviewDbContext())
            {
                var clientIdParameter = new SqlParameter("@empID", empID);

                result = context.Database
                    .SqlQuery<ReviewAll>("Review_Select_By_EmpID @empID", clientIdParameter)
                    .ToList();
            }
            return result;

        }

        public IList<Employee> GetEmployees()
        {
            return reviewDbContext.Employees.ToList();
        }

        public IEnumerable<Employee> GetEmployees(int RoleID)
        {
            return reviewDbContext.Employees.Where(x => x.RoleID == RoleID).ToList();
        }


        /// <summary>
        /// Get the employee question by name
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        public IEnumerable<Questions> GetQuestionsByEmployee(int RoleID)
        {
            return reviewDbContext.Questions.Where(x=> x.RoleID== RoleID || x.RoleID==5).ToList();
        }

        public IEnumerable<Questions> GetQuestions()
        {
            return reviewDbContext.Questions.ToList();
        }

        public IEnumerable<Project> GetProjects()
        {
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
            return reviewDbContext.Roles.ToList();
        }

        public IEnumerable<Ratings> GetAnswerRating()
        {
            return reviewDbContext.Responses.ToList();
        }

    }
}