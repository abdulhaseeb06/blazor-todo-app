using Microsoft.EntityFrameworkCore;

namespace TodoApp.Data
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Todo> Todos { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}
