using Employes_manager.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Employes_manager.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
    }
}

