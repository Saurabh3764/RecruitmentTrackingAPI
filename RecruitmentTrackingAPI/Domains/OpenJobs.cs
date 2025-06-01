using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.Domains
{
    public class OpenJobs
    {
        [Key]
        public Guid JobID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        [DefaultValue(1)]
        public int NumberOfOpenJobs { get; set; }
        public int JobPostedDay { get; set; }
        public HiringManager Manager { get; set; }
    }
}
