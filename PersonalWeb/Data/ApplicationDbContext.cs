using Microsoft.EntityFrameworkCore;
using PersonalWeb.Models.Entities;

namespace PersonalWeb.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserInfo> userInfos { get; set; }
        public DbSet<Edu> edus { get; set; }
        public DbSet<Work> works { get; set; }
        public DbSet<Project> projects { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}