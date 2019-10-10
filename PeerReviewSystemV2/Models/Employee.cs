using System.ComponentModel.DataAnnotations;

namespace PeerReviewSystemV2.Controllers
{

    public class Employee
    {
        [Key]
        public int empID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }


        //Nav Properties
        public Review Review { get; set; }
        //public List<Review> Reviews { get; set; }


    }
}