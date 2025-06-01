using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.DTO.ResponseDTO
{
    public class AdminsDTO
    {
        [Key]
        public Guid AdminID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
