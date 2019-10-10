using System.Data.Entity;

namespace PeerReviewSystemV2.Controllers
{
    public class ReviewDbContext: DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Rating> Responses { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobRole> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }


    }
}   