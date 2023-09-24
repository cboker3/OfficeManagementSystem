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
        }

        public void SeedData()
        {
            Randomizer.Seed = new Random(8675309);

            SeedEventCatagories();
            SeedEvents();
            SeedAttendees();
            SeedTasks();
            SeedMessages();
            SeedUsers();
            SeedContacts();
            SeedVenues();
            SeedResources();
            SeedBudgetItems();
        }

        private void SeedBudgetItems()
        {
            throw new NotImplementedException();
        }

        private void SeedResources()
        {
            throw new NotImplementedException();
        }

        private void SeedVenues()
        {
            throw new NotImplementedException();
        }

        private void SeedContacts()
        {
            throw new NotImplementedException();
        }

        private void SeedUsers()
        {
            throw new NotImplementedException();
        }

        private void SeedMessages()
        {
            throw new NotImplementedException();
        }

        private void SeedTasks()
        {
            var priority = new[] { "High", "Medium", "Low" };
            var status = new[] { "In-Process", "Completed", "Pending", "Unassigned" };

            var tasksFaker = new Faker<Tasks>()
                .RuleFor(e => e.DueDate, f => f.Date.Recent())
                .RuleFor(e => e.Description, f => f.Lorem.Sentence())
                .RuleFor(e => e.Priority, f => f.Random.Number(1, 10))
                .RuleFor(e => e.Status, f => f.Random.Number(1, 5));
            //throw new NotImplementedException();
        }

        private void SeedAttendees()
        {
            var attendeesFaker = new Faker<Attendees>()
                .RuleFor(e => e.FirstName, f => f.Name.FirstName())
                .RuleFor(e => e.LastName, f => f.Name.LastName())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                .RuleFor(e => e.EventsID, f => f.Random.Number(1, 10));

            var attendees = attendeesFaker.Generate(10);

            Attendees.AddRange(attendees);
            //throw new NotImplementedException();
        }

        private void SeedEvents()
        {
            var attendeesFaker = new Faker<Attendees>()
                .StrictMode(true)
                .RuleFor(e => e.FirstName, f => f.Name.FirstName())
                .RuleFor(e => e.LastName, f => f.Name.LastName())
                .RuleFor(e => e.Email, f => f.Internet.Email());

            // Seed Events table
            var eventFaker = new Faker<Events>()
                .RuleFor(e => e.Name, f => f.Lorem.Sentence())
                .RuleFor(e => e.Description, f => f.Lorem.Paragraph())
                .RuleFor(e => e.StartDate, f => f.Date.Recent())
                .RuleFor(e => e.EndDate, f => f.Date.Future())
                .RuleFor(e => e.CategoryID, f => f.Random.Number(1, 5)) // Assuming 5 categories
                .RuleFor(e => e.VenuesID, f => f.Random.Number(1, 5));



            var events = eventFaker.Generate(10); // Generate 10 random events

            Events.AddRange(events);
            SaveChanges();

            //throw new NotImplementedException();
        }

        private void SeedEventCatagories()
        {
            throw new NotImplementedException();
        }
    }
}
