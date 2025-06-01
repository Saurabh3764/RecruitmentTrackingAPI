using AutoMapper;
using RecruitmentTrackingAPI.Domains;
using RecruitmentTrackingAPI.DTO.RequestDTO;
using RecruitmentTrackingAPI.DTO.ResponseDTO;

namespace RecruitmentTrackingAPI.Mappings
{
    public class MappingProfiler : Profile
    {
        public MappingProfiler()
        {
            CreateMap<Admins, AdminsDTO>().ReverseMap();    
            CreateMap<Admins, AddAdminDTO>().ReverseMap();    
            CreateMap<AdminsDTO, AddAdminDTO>().ReverseMap();    
        }
    }
}
