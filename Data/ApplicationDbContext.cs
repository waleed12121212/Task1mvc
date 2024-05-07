using Microsoft.EntityFrameworkCore;
using task2.Models;

namespace task2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.;database=Task1Mvc;trusted_connection=true;trustServerCertificate=true");
        #region 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
              new Employee { Id = 1 , Name = "Waleed" , Age = 21 , Title = "Nablus" } ,
              new Employee { Id = 2 , Name = "Ahmad" , Age = 31 , Title = "Tulkarm" } ,
              new Employee { Id = 3 , Name = "Tariq" , Age = 25 , Title = "Ramallah" } ,
              new Employee { Id = 4 , Name = "Rami" , Age = 44 , Title = "Nablus" } ,
              new Employee { Id = 5 , Name = "Shadi" , Age = 63 , Title = "Selfit" } ,
              new Employee { Id = 6 , Name = "Sami" , Age = 41 , Title = "Jinen" } ,
              new Employee { Id = 7 , Name = "Khaled" , Age = 20 , Title = "Nablus" }
            );
        }
        #endregion
    }
}
