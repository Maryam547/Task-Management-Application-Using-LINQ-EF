using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Models
{
    public class TaskManagementContext:DbContext
    {
        public DbSet<Task> Tasks { get; set; } 
        public DbSet<User> Users { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5R1EPAT;Database=TaskManagement;Trusted_connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.User)
                .WithMany(u => u.tasks)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Task>()
        .HasMany(t => t.Reminders)
        .WithOne(r => r.Task)
        .HasForeignKey(r => r.TaskId)
        .OnDelete(DeleteBehavior.Cascade); 

            }


    }


}
