using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OfficeManagementSystem.Models;

using Bogus;



namespace OfficeManagementSystem.Data
{
    public class OMScontext : DbContext
    {

        public DbSet<Attendees> Attendees { get; set; }
        public DbSet<BudgetItems> BudgetItems { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<EventCategories> EventCategories { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Venues> Venues { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost; Database=OMS_DB; Trusted_Connection=true;"
                );

            /*optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb; Database=OfficeManagmentSystemDB; Trusted_Connection=true;"
                );
            /*optionsBuilder.UseSqlite(
                "Data Source=mydb.db; Version=3;"
                );*/

            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            var datagenerator = new DataGenerator();


            modelBuilder.Entity<Venues>().HasData(datagenerator.venues);
            modelBuilder.Entity<EventCategories>().HasData(datagenerator.eventCategories);
            modelBuilder.Entity<Events>().HasData(datagenerator.events);
            modelBuilder.Entity<Attendees>().HasData(datagenerator.attendees);
            modelBuilder.Entity<BudgetItems>().HasData(datagenerator.budgetItems);
            modelBuilder.Entity<Contacts>().HasData(datagenerator.contacts);
            modelBuilder.Entity<Messages>().HasData(datagenerator.messages);
            modelBuilder.Entity<Resources>().HasData(datagenerator.resources);
            modelBuilder.Entity<Tasks>().HasData(datagenerator.tasks);
            modelBuilder.Entity<Users>().HasData(datagenerator.users);


        }
    }
}
