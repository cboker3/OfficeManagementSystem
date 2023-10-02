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
using Org.BouncyCastle.Utilities;
using System.Collections.Immutable;

namespace OfficeManagementSystem.Data
{

    public class DataGenerator
    {
        OMScontext dbContext = new OMScontext();
        int fakerConst = 8675309;

        Faker<Attendees> attendeeFaker;
        Faker<Events> eventFaker;
        Faker<Messages> messageFaker;
        Faker<Users> userFaker;

        public IReadOnlyCollection<Attendees> attendees { get; } = new List<Attendees>();
        public IReadOnlyCollection<BudgetItems> budgetItems { get; } = new List<BudgetItems>();
        public IReadOnlyCollection<Contacts> contacts { get; } = new List<Contacts>();
        public IReadOnlyCollection<EventCategories> eventCategories { get; } = new List<EventCategories>();
        public IReadOnlyCollection<Events> events { get; } = new List<Events>();
        public IReadOnlyCollection<Messages> messages { get; } = new List<Messages>();
        public IReadOnlyCollection<Resources> resources { get; } = new List<Resources>();
        public IReadOnlyCollection<Tasks> tasks { get; } = new List<Tasks>();
        public IReadOnlyCollection<Users> users { get; } = new List<Users>();
        public IReadOnlyCollection<Venues> venues { get; } = new List<Venues>();

        public DataGenerator()
        {
            eventCategories = SeedEventCatagories(amount: 10);
            venues = SeedVenues(amount: 20);
            contacts = SeedContacts(amount: 50);
            users = SeedUsers(amount: 20);

            events = SeedEvents(amount: 200, eventCategories, venues);

            attendees = SeedAttendees(amount: 200, events);

            budgetItems = SeedBudgetItems(amount: 50, events);
            resources = SeedResources(amount: 50, events);

            messages = SeedMessages(amount: 50, users);
            tasks = SeedTasks(amount: 20, events);
        }

        private static IReadOnlyCollection<Tasks> SeedTasks(int amount, IEnumerable<Events> events)
        {
            var tasksID = 1;

            var tasksFaker = new Faker<Tasks>()
                .RuleFor(e => e.ID, f => tasksID++)
                .RuleFor(e => e.DueDate, f => f.Date.Recent())
                .RuleFor(e => e.Description, f => f.Lorem.Sentence())
                .RuleFor(e => e.Priority, f => f.Random.Number(1, 10))
                .RuleFor(e => e.Status, f => f.Random.Number(1, 5))
                .RuleFor(e => e.EventsID, f => f.PickRandom<Events>(events).ID);

            return tasksFaker.Generate(amount);
        }

        private static IReadOnlyCollection<Messages> SeedMessages(int amount, IEnumerable<Users> users)
        {
            var messagesID = 1;

            var messageFaker = new Faker<Messages>()
                .RuleFor(u => u.ID, f => messagesID++)
                .RuleFor(u => u.Content, f => f.Lorem.Letter())
                .RuleFor(u => u.Subject, f => f.Lorem.Sentence())
                .RuleFor(u => u.Timestamp, f => f.Date.Recent())
                .RuleFor(u => u.ReceiverID, f => f.PickRandom<Users>(users).ID)
                .RuleFor(u => u.SenderID, f => f.PickRandom<Users>(users).ID);



            return messageFaker.Generate(amount);
        }

        private static IReadOnlyCollection<Resources> SeedResources(int amount, IEnumerable<Events> events)
        {
            var resourcesID = 1;

            var resourcesFaker = new Faker<Resources>()
                .RuleFor(e => e.ID, f => resourcesID++)
                .RuleFor(e => e.Description, f => f.Lorem.Sentence())
                .RuleFor(e => e.Name, f => f.Commerce.Product())
                .RuleFor(e => e.Quantity, f => f.Random.Number(1, 40))
                .RuleFor(e => e.EventsID, f => f.PickRandom<Events>(events).ID);

            return resourcesFaker.Generate(amount);
        }

        private static IReadOnlyCollection<BudgetItems> SeedBudgetItems(int amount, IEnumerable<Events> events)
        {
            var budgetItemsID = 1;

            var budgetItemsFaker = new Faker<BudgetItems>()
                .RuleFor(e => e.ID, f => budgetItemsID++)
                //.RuleFor(e => e.Amount, f => Convert.ToDecimal(f.Commerce.Price(1, 150, 2, "$")))
                .RuleFor(e => e.Description, f => f.Lorem.Sentence())
                .RuleFor(e => e.Type, f => f.Random.Number(1, 5))
                .RuleFor(e => e.Date, f => f.Date.Soon())
                .RuleFor(e => e.EventsID, f => f.PickRandom<Events>(events).ID);

            return budgetItemsFaker.Generate(amount);
        }

        private static IReadOnlyCollection<Attendees> SeedAttendees(int amount, IEnumerable<Events> events)
        {
            var attendeesID = 1;

            var attendeesFaker = new Faker<Attendees>()
                .RuleFor(e => e.ID, f => attendeesID++)
                .RuleFor(e => e.FirstName, f => f.Name.FirstName())
                .RuleFor(e => e.LastName, f => f.Name.LastName())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                .RuleFor(e => e.EventsID, f => f.PickRandom<Events>(events).ID)
                .RuleFor(e => e.RegistrationDate, f => f.Date.Recent());

            return attendeesFaker.Generate(amount);
        }

        private static IReadOnlyCollection<Events> SeedEvents(int amount, IEnumerable<EventCategories> eventCategories, IEnumerable<Venues> venues)
        {
            var eventID = 1;

            var eventFaker = new Faker<Events>()
                .RuleFor(e => e.ID, f => eventID++)
                .RuleFor(e => e.Name, f => f.Lorem.Sentence())
                .RuleFor(e => e.Description, f => f.Lorem.Paragraph())
                .RuleFor(e => e.StartDate, f => f.Date.Recent())
                .RuleFor(e => e.EndDate, f => f.Date.Future())
                .RuleFor(e => e.CategoryID, f => f.PickRandom(eventCategories).ID)
                .RuleFor(e => e.VenuesID, f => f.PickRandom(venues).ID);

            return eventFaker.Generate(amount); 

        }

        private static IReadOnlyCollection<Users> SeedUsers(int amount)
        {
            var userID = 1;
            var usersFaker = new Faker<Users>()
                .RuleFor(e => e.ID, f => userID++)
                .RuleFor(e => e.FirstName, f => f.Name.FirstName())
                .RuleFor(e => e.LastName, f => f.Name.LastName())
                .RuleFor(e => e.Username, f => f.Internet.Email())
                .RuleFor(e => e.Password, f => f.Random.Bytes(20))
                .RuleFor(e => e.Role, f => f.Hacker.Adjective());

            return usersFaker.Generate(amount);
        }

        private static IReadOnlyCollection<Contacts> SeedContacts(int amount)
        {
            var contactID = 1;
            var contactsFaker = new Faker<Contacts>()
                .RuleFor(e => e.ID, f => contactID++)
                .RuleFor(e => e.FirstName, f => f.Name.FirstName())
                .RuleFor(e => e.LastName, f => f.Name.LastName())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                .RuleFor(e => e.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(e => e.Organization, f => f.Company.CompanyName());

            return contactsFaker.Generate(amount);
        }

        private static IReadOnlyCollection<Venues> SeedVenues(int amount)
        {
            var venueID = 1;
            var venueFaker = new Faker<Venues>()
                .RuleFor(x => x.ID, f => venueID++)
                .RuleFor(x => x.Name, f => f.Hacker.Noun())
                .RuleFor(x => x.Address, f => f.Address.FullAddress())
                .RuleFor(x => x.Capacity, f => f.Random.Int(10, 300))
                .RuleFor(x => x.CompanyOwned, f => f.Random.Bool())
                .RuleFor(x => x.LayoutDiagram, f => f.Random.Bytes(50));

            return venueFaker.Generate(amount);
            
        }

        private static IReadOnlyCollection<EventCategories> SeedEventCatagories(int amount)
        {
            var eventCatID = 1;
            var eventCatFaker = new Faker<EventCategories>()
                .RuleFor(x => x.ID, f => eventCatID++)
                .RuleFor(x => x.Name, f => f.Lorem.Word());

            return eventCatFaker.Generate(amount); ;
        }
    }
}