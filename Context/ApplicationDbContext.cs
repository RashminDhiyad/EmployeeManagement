using DxBlazorCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace DxBlazorCRUD.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
