using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.Domains
{
    public class Applicants
    {
        [Key]
        public Guid ApplicantID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string? Fresher { get; set; }
        public string? Experience { get; set; }
        public string? LinkedIn { get; set; }

 
    }
}
