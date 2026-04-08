using Microsoft.EntityFrameworkCore;

namespace CODE_FIRST.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Khai báo tập thực thể (Bảng)
        public DbSet<BacSi> BacSis { get; set; }
    }
}