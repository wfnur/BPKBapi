using Microsoft.EntityFrameworkCore;

namespace BPKBapi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> ms_user { get; set; }
        public DbSet<StorageLocation> ms_storage_locations { get; set; }
        public DbSet<BPKB> tr_bpkb { get; set; }
    }
}
