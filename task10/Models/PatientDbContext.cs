using Microsoft.EntityFrameworkCore;

namespace task10.Models
{
    public class PatientDbContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        
        public PatientDbContext(){}

        public PatientDbContext(DbContextOptions options) : base(options){}
    }
}