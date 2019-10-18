using System.ComponentModel.DataAnnotations;

namespace PeerReviewSystem.Models
{
    public class Answers
    {
       [Key]
        public int answerID { get; set; }
        string rating;

        public string Rating { get => rating; set => rating = value; }
        public Review Review { get; set; }

    }
}