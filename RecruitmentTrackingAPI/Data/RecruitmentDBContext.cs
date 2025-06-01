using Microsoft.EntityFrameworkCore;
using RecruitmentTrackingAPI.Domains;

namespace RecruitmentTrackingAPI.Data
{
    public class RecruitmentDBContext :DbContext
    {
       public RecruitmentDBContext(DbContextOptions<RecruitmentDBContext> options) : base(options)
       {
                
       }
       DbSet<Admins> Admin { get; set; }
       DbSet<OpenJobs> OpenJob { get; set; }
       DbSet<Applicants> Applicant { get; set; }
       DbSet<HiringManager> ConcernedManager { get; set; }
       DbSet<JobApplications> JobApplication { get; set; }
    }
}
