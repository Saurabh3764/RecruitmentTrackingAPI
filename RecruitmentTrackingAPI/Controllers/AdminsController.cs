using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RecruitmentTrackingAPI.Domains;
using RecruitmentTrackingAPI.DTO.RequestDTO;
using RecruitmentTrackingAPI.DTO.ResponseDTO;
using RecruitmentTrackingAPI.RepositoryPatterns.Interface;
using RecruitmentTrackingAPI.SharedServices.StaticMessages;

namespace RecruitmentTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly IAdmins _admins;
        private readonly IMapper _mapper;
    

        public AdminsController(IAdmins admins, IMapper mapper )
        {
            _admins = admins;
            _mapper = mapper;
          
        }
        // GET: api/Admins
        [HttpGet]
        [Route("/GetAdmins")]   
        public async Task<IActionResult> GetAdmins()
        {
            try
            {
                var admins = await _admins.GetAdminsAsync();
                if (admins == null || !admins.Any())
                {
                    return NotFound(ConstMessages.NoAdminMessage);
                }
                return Ok(_mapper.Map<List<AdminsDTO>>(admins));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("/CreateAdmin")]
        public async Task<IActionResult> CreateAdmin([FromBody] AddAdminDTO adminDto)
        {
           
                try
                {
                    if(ModelState.IsValid == false)
                    {
                        return BadRequest(ModelState);
                    }
                    var admin = await _admins.CreateAdminAsync(_mapper.Map<Admins>(adminDto));    
                    return Ok(_mapper.Map<AdminsDTO>(admin));

                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
                }
        }

        [HttpDelete]
        [Route("/DeleteAdminByEmail")]
        public async Task<IActionResult> DeleteAdminByEmail([FromBody] string email)
        {
            try
            { 
                var admin = await _admins.DeleteAdminAsync(email);
                if (admin == null)
                {
                    return NotFound(ConstMessages.InvalidAdminID);
                }
                
                return Ok(ConstMessages.AdminDeletedSuccessfully);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

    }
}
