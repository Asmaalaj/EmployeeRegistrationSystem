using Microsoft.EntityFrameworkCore;
using EmployeeRegistrationSystem.Models;

namespace EmployeeRegistrationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}                                                                                                                                    