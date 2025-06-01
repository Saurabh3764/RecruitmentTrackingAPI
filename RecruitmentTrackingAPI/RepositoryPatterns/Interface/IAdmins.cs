using Microsoft.AspNetCore.Mvc;
using RecruitmentTrackingAPI.Domains;

namespace RecruitmentTrackingAPI.RepositoryPatterns.Interface
{
    public interface IAdmins
    {
        public  Task<List<Admins>> GetAdminsAsync();
        public  Task<Admins> CreateAdminAsync(Admins admin);
        public  Task<Admins> DeleteAdminAsync(string email);
       
    }
}
