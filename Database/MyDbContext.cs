using Microsoft.EntityFrameworkCore;

namespace AlperAzureApp.Database
{
    public class MyDbContext : DbContext
    {
        public static string DbConnectionString =
            "Server=tcp:alperazureserver.database.windows.net,1433;" +
            "Initial Catalog=AlperAzureDb;" +
            "Persist Security Info=False;" +
            "User ID=alper;" +
            "Password=1q2w3E**;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";

        /*
           S e r v e r : alperazureserver
           U s e r     : alper
           P a s s     : 1q2w3E**
         */

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
    }
}
