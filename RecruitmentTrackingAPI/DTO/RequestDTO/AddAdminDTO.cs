using RecruitmentTrackingAPI.SharedServices.StaticMessages;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentTrackingAPI.DTO.RequestDTO
{
    public class AddAdminDTO
    {
        [Required(ErrorMessage = ConstMessages.MandatoryFields)]
        public string Name { get; set; }
        [Required(ErrorMessage = ConstMessages.MandatoryFields), EmailAddress(ErrorMessage = ConstMessages.InValidEmail)]
        public string Email { get; set; }
        [Required(ErrorMessage = ConstMessages.MandatoryFields), Phone(ErrorMessage = ConstMessages.InvalidPhoneNumber)]
        public string Contact { get; set; }
    }
}
