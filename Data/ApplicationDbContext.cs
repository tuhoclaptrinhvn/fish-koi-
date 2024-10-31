using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Data // Thay thế YourNamespace bằng namespace thực tế của bạn
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Đặt DbSet cho các thực thể của bạn
        public DbSet<Fish> Fishes { get; set; } // Ví dụ: Bảng cá
    }

    // Lớp thực thể tương ứng với bảng trong cơ sở dữ liệu
    public class Fish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
    }
}
