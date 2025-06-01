using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.Domains
{
    public class HiringManager
    {
        [Key]
        public Guid ManagerID { get; set; }
        public Guid Name { get; set; }
        public Guid Email { get; set; }
        public Guid Contact { get; set; }
    }
}
