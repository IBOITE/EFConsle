using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFConsle
{
    public class ApplicationDbContext :DbContext
    {
        //web app'da genellikle appseting'da bulunyor yani bu yazmiyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            //connection string , sql server => properties'den getirdim ve (@) eklidim
            option.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=EFconsole;Integrated Security=True");
        }

        //FluentAPI
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Set default value (bir prop'e bir default deger ekliyor)
            modelBuilder.Entity<Employee>().Property(b => b.sayici).HasDefaultValue(2);

            //set default value  ve burada sql statement kullanmasiyla
            modelBuilder.Entity<Employee>().Property(b => b.tarih).HasDefaultValueSql("GETDATE()");

            //sql statement kullanmasiyla value baska prop'tan almak 
            modelBuilder.Entity<Author>().Property(p => p.FirstVeLast).HasComputedColumnSql("[FirstName] + [LastName]");
        }


        //tablolar eklemek
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category > Categories { get; set; }
    }
}
