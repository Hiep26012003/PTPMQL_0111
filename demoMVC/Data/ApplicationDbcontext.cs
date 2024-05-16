using Microsoft.EntityFrameworkCore;
using demoMVC.Models;

namespace demoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Person> Persons {get; set;}
        public DbSet<Employee> Employee {get; set;}
    }
}