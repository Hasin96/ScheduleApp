using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Schedule.Models
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext()
        {

        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskColor> TaskColors { get; set; }
        public DbSet<TaskFontAwesomeIcon> TaskFontAwesomeIcons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlServer(@"Server=DESKTOP-9FIIT8Q\SQLEXPRESS;Database=Schedule;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .Property(t => t.Title)
                .HasMaxLength(55)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<TaskColor>()
                .Property(tc => tc.Color)
                .HasMaxLength(10)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<TaskFontAwesomeIcon>()
                .Property(tswi => tswi.FolderUrl)
                .HasColumnType("varchar")
                .HasMaxLength(55)
                .IsRequired();

            modelBuilder.Entity<TaskFontAwesomeIcon>()
                .Property(tswi => tswi.FileName)
                .HasMaxLength(55)
                .HasColumnType("varchar")
                .IsRequired();

        }
        
    }
}
