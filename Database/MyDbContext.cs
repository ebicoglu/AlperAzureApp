using Microsoft.EntityFrameworkCore;

namespace AlperAzureApp.Database
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
    }
}
