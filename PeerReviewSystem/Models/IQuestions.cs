namespace PeerReviewSystem.Models
{
    public interface IQuestions
    {
        string Question { get; set; }
        int questionID { get; set; }
        JobRole Role { get; set; }
        int RoleID { get; set; }
    }
}