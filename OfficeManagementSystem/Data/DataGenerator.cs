using Bogus;
using OfficeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OfficeManagementSystem.Models;

using Bogus;
using System.Diagnostics;
using OfficeManagementSystem.Data;

namespace OfficeManagementSystem.Data
{

    public class DataGenerator
    {
        OMScontext dbContext = new OMScontext();

        Faker<Attendees> attendeeFaker;
        Faker<Events> eventFaker;
        Faker<Messages> messageFaker;
        Faker<Users> userFaker;



        //public DataGenerator()
        //{
        //    Randomizer.Seed = new Random(123);

        //    attendeeFaker = new Faker<Attendees>()
        //        .RuleFor(u => u.FirstName, f => f.Name.FirstName())
        //        .RuleFor(u => u.LastName, f => f.Name.LastName())
        //        .RuleFor(u => u.RegistrationDate, f => f.Date.Recent())
        //        .RuleFor(u => u.PaymentStatus, f => false);



        //    userFaker = GetUserGenerator();


        //    messageFaker = new Faker<Messages>()
        //        .RuleFor(u => u.Content, f => f.Lorem.Letter())
        //        .RuleFor(u => u.Subject, f => f.Lorem.Sentence())
        //        .RuleFor(u => u.Timestamp, f => f.Date.Recent())



        //}

        public Faker<Messages> GetMessagesGenerator()
        {
            var userFaker = GetUserGenerator();

            messageFaker = new Faker<Messages>()
                .RuleFor(u => u.Content, f => f.Lorem.Letter())
                .RuleFor(u => u.Subject, f => f.Lorem.Sentence())
                .RuleFor(u => u.Timestamp, f => f.Date.Recent())
                .RuleFor(u => u.SenderID, f => userFaker.Generate().ID)
                .RuleFor(u => u.ReceiverID, f => userFaker.Generate().ID);

            dbContext.Messages.Add(messageFaker);

            return messageFaker;
        }

        public Faker<Users> GetUserGenerator()
        {
            userFaker = new Faker<Users>()
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Username, f => f.Hacker.Noun())
                .RuleFor(u => u.Role, f => f.Hacker.Verb());

            dbContext.Users.Add(userFaker);

            return userFaker;
        }

    //    public AttendeeModel GenerateAttendeeModel()
    //    {
    //        if (attendeeFaker is null)
    //        {
    //            attendeeFaker = new Faker<Attendees>()
    //                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
    //                .RuleFor(u => u.LastName, f => f.Name.LastName())
    //                .RuleFor(u => u.RegistrationDate, f => f.Date.Recent())
    //                .RuleFor(u => u.PaymentStatus, f => false);
    //        }
    //    }
    
    //public void SeedData()
    //    {
    //        Randomizer.Seed = new Random(8675309);

    //        SeedEventCatagories();
    //        SeedEvents();
    //        SeedAttendees();
    //        SeedTasks();
    //        SeedMessages();
    //        SeedUsers();
    //        SeedContacts();
    //        SeedVenues();
    //        SeedResources();
    //        SeedBudgetItems();
    //    }

    //    private void SeedBudgetItems()
    //    {
    //        var budgetItemsFaker = new Faker<BudgetItems>()
    //            .RuleFor(e => e.Amount, f => f.Random.Number(1, 5))
    //            .RuleFor(e => e.Description, f => f.Lorem.Sentence())
    //            .RuleFor(e => e.Type, f => f.Random.Number(1, 5))
    //            .RuleFor(e => e.Date, f => f.Date.Soon());

    //    }


    //    private void SeedTasks()
    //    {
    //        var priority = new[] { "High", "Medium", "Low" };
    //        var status = new[] { "In-Process", "Completed", "Pending", "Unassigned" };

    //        var tasksFaker = new Faker<Tasks>()
    //            .RuleFor(e => e.DueDate, f => f.Date.Recent())
    //            .RuleFor(e => e.Description, f => f.Lorem.Sentence())
    //            .RuleFor(e => e.Priority, f => f.Random.Number(1, 10))
    //            .RuleFor(e => e.Status, f => f.Random.Number(1, 5));
    //        //throw new NotImplementedException();
    //    }

    //    public void SeedAttendees()
    //    {
    //        var attendeesFaker = new Faker<Attendees>()
    //            .RuleFor(e => e.FirstName, f => f.Name.FirstName())
    //            .RuleFor(e => e.LastName, f => f.Name.LastName())
    //            .RuleFor(e => e.Email, f => f.Internet.Email())
    //            .RuleFor(e => e.EventsID, f => f.Random.Number(1, 10));

    //        //var attendees = attendeesFaker.Generate(10);

    //        //return attendees;
    //        //throw new NotImplementedException();
    //    }

    //    public void SeedEvents()
    //    {
    //        // Seed Events table
    //        var eventFaker = new Faker<Events>()
    //            .RuleFor(e => e.Name, f => f.Lorem.Sentence())
    //            .RuleFor(e => e.Description, f => f.Lorem.Paragraph())
    //            .RuleFor(e => e.StartDate, f => f.Date.Recent())
    //            .RuleFor(e => e.EndDate, f => f.Date.Future())
    //            .RuleFor(e => e.CategoryID, f => f.Random.Number(1, 5)) // Assuming 5 categories
    //            .RuleFor(e => e.VenuesID, f => f.Random.Number(1, 5))
    //            .RuleFor(u => u.Venues, f => SeedAttendees.Generate(3).ToList());



    //        var events = eventFaker.Generate(10); // Generate 10 random events

    //        Events.AddRange(events);
    //        SaveChanges();

    //        //throw new NotImplementedException();
    //    }

    //    public void SeedEventCatagories()
    //    {
    //        var category = new[] { "Dance", "Convention", "Presentation", "Party", "Fund Raiser" };

    //        var eventCatFaker = new Faker<EventCategories>()
    //            .RuleFor(e => e.Name, f => category[f.Random.Number(0, 4)]); // Assuming 5 categories
    //        throw new NotImplementedException();
    //    }
    }
}