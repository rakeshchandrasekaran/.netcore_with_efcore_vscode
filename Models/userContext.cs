using Microsoft.EntityFrameworkCore;

namespace User_DotNet_Core.Models
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options)
            : base(options)
        {
        }

        public DbSet<userModel> userModels { get; set; }
    }
}