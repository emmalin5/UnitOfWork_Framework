using FinprintProject.Models.StudentRegistration;
using Microsoft.EntityFrameworkCore;

namespace FinprintProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<FingerprintRegister> Fingerprint { get; set; }
        public DbSet<StudentRegister> Student { get; set; }
    }
}
