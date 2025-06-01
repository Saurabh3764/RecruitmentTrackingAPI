using Microsoft.EntityFrameworkCore;
using RecruitmentTrackingAPI.Domains;

namespace RecruitmentTrackingAPI.Data
{
    public class RecruitmentDBContext :DbContext
    {
       public RecruitmentDBContext(DbContextOptions<RecruitmentDBContext> options) : base(options)
       {
                
       }
        public DbSet<Admins> Admin { get; set; }
        public DbSet<OpenJobs> OpenJob { get; set; }
        public DbSet<Applicants> Applicant { get; set; }
        public DbSet<HiringManager> ConcernedManager { get; set; }
        public DbSet<JobApplications> JobApplication { get; set; }
    }
}
