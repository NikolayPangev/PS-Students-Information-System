using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source = {databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(e => e.Id).ValueGeneratedOnAdd();

            var user1 = new User()
            {
                Id = 1,
                Name = "John Doe",
                Role = UserRolesEnum.ADMIN,
                Expires = DateTime.Now.AddYears(10)
            };

            var user2 = new User()
            {
                Id = 2,
                Name = "Marry Jane",
                Role = UserRolesEnum.PROFESSOR,
                Expires = DateTime.Now.AddYears(20)
            };

            var user3 = new User()
            {
                Id = 3,
                Name = "Mark Jones",
                Role = UserRolesEnum.STUDENT,
                Expires = DateTime.Now.AddYears(30)
            };

            modelBuilder.Entity<User>().HasData(user);
        }
            public DbSet<User> Users { get; set; }
        }
    }

