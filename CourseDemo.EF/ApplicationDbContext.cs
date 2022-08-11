using CourseDemo.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseDemo.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseGainSkill>().HasKey(gs => new { gs.CourseId, gs.SkillId });
            modelBuilder.Entity<CourseRequiredSkill>().HasKey(rs => new { rs.CourseId, rs.SkillId });
            modelBuilder.Entity<CourseModule>().HasKey(cm => new { cm.CourseId, cm.ModuleId });
            modelBuilder.Entity<Course>().HasIndex(c => c.Reference).IsUnique();
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CourseType> Types { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<CourseGainSkill> CourseGainSkills { get; set; }
        public DbSet<CourseRequiredSkill> CourseRequiredSkills { get; set; }
        public DbSet<CourseModule> CourseModules { get; set; }
    }
}
