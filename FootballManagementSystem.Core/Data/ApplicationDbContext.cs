using FootballManagementSystem.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Emit;

namespace FootballManagementSystem.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<FootballClub> FootballClubs { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<MatchProgram> MatchPrograms { get; set; }

        public DbSet<MedicalList> MedicalLists { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            builder.Entity<User>(u =>
            {
                u.HasOne(u => u.Employee).WithOne(u => u.User).OnDelete(DeleteBehavior.Restrict);
            });


            builder.Entity<Employee>(e =>
            {
                e.HasOne(e => e.User).WithOne(u => u.Employee).OnDelete(DeleteBehavior.Restrict);
                e.Property(e => e.isDeleted).HasDefaultValue(false);


            });

            builder.Entity<FootballClub>(f =>
            {
                f.Property(f => f.IsDeleted).HasDefaultValue(false);
            });


            builder.Entity<MatchProgram>(mp =>
            {
                mp.Property(mp => mp.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<MedicalList>(ml =>
            {
                ml.Property(ml => ml.IsDeleted).HasDefaultValue(false);
            });

            builder.Entity<Schedule>(s =>
            {
                s.Property(s => s.IsDeleted).HasDefaultValue(false);
            });


        }
    }
}