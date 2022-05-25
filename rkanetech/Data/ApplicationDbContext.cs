using Microsoft.EntityFrameworkCore;
using rkanetech.Models;

namespace rkanetech.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder opts) => opts.UseNpgsql();

        DbSet<AddressModel> Addresses { get; set; }
        DbSet<UserModel> Users { get; set; }
    }
}
