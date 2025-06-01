using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.Domains
{
    public class JobApplications
    {
        [Key]
        public Guid ApplicationID { get; set; }
        public Guid JobID { get; set; }
        public DateTime DateOfApplication { get; set; }
        public ICollection<Applicants> Applicants  { get; set; }

    }
}
