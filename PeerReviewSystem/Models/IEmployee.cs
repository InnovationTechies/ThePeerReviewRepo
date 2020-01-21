namespace PeerReviewSystem.Models
{
    public interface IEmployee
    {
        int empID { get; set; }
        JobRole JobRole { get; set; }
        string Name { get; set; }
        int RoleID { get; set; }
        string Surname { get; set; }
    }
}