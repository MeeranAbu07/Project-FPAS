using FPAS.Model.Entites;
using Microsoft.EntityFrameworkCore;

namespace FPAS.Model
{
    public class FPASDbContext : DbContext
    {
        public FPASDbContext(DbContextOptions<FPASDbContext> options) : base(options) 
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfile { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
