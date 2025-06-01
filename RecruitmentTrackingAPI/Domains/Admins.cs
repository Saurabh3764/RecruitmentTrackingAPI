using RecruitmentTrackingAPI.SharedServices.StaticMessages;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.Domains
{
    public class Admins
    {
        [Key]
        public Guid AdminID { get; set; }
        [Required(ErrorMessage = ConstMessages.MandatoryFields)]
        public string Name { get; set; }
        [Required(ErrorMessage =ConstMessages.MandatoryFields), EmailAddress(ErrorMessage = ConstMessages.InValidEmail)]
        public string Email { get; set; }
        [Required(ErrorMessage = ConstMessages.MandatoryFields), Phone(ErrorMessage =ConstMessages.InvalidPhoneNumber)]
        public string Contact { get; set; }
    }
}
