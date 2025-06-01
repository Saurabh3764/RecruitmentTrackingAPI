using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecruitmentTrackingAPI.Data;
using RecruitmentTrackingAPI.Domains;
using RecruitmentTrackingAPI.RepositoryPatterns.Interface;

namespace RecruitmentTrackingAPI.RepositoryPatterns.Implementations
{
    public class AdminsRepository : IAdmins
    {
        private readonly RecruitmentDBContext _dBContext;

        public AdminsRepository(RecruitmentDBContext dBContext) 
        {
            _dBContext = dBContext;
        }

        public async Task<Admins> CreateAdminAsync(Admins admin)
        {
             await _dBContext.Admin.AddAsync(admin);
             await _dBContext.SaveChangesAsync();
             return admin;
        }

        public async Task<Admins> DeleteAdminAsync(string email)
        {
           var admin = await _dBContext.Admin.FirstOrDefaultAsync(x=>x.Email == email);
           if(admin == null)
           {
               return null; // Or throw an exception if preferred   
            }
            _dBContext.Admin.Remove(admin);
            await _dBContext.SaveChangesAsync();
            return admin;

        }

        public async Task<List<Admins>> GetAdminsAsync()
        {
             return await(_dBContext.Admin.ToListAsync());
        }
    }
}
