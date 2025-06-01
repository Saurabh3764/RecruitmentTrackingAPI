using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.Domains
{
    public class Admins
    {
        [Key]
        public Guid AdminID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
