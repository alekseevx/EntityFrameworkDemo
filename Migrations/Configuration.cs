namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EntityFrameworkDemo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkDemo.DBContext.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameworkDemo.DBContext.Context context)
        {
#if false
            var clients = new List<Client>
            {
                new Client {FirstName = "Dan", LastName = "Simmons"},
                new Client {FirstName = "Bob", LastName = "Builder"},
                new Client {FirstName = "Scott", LastName = "Markov"}
            };
            foreach (var client in clients)
                context.Clients.AddOrUpdate(client);
            context.SaveChanges();

            var projects = new List<Project>
            {
                new Project
                {
                    Client = context.Clients.Single(c => c.FirstName == "Dan"),
                    StartDate = new DateTime(2015, 10, 15),
                    EndDate = new DateTime(2016, 10, 15),
                    Title = "Entity Framework Project"
                },
                new Project
                {
                    Client = context.Clients.Single(c => c.FirstName == "Bob"),
                    StartDate = new DateTime(2015, 10, 15),
                    EndDate = new DateTime(2016, 10, 15),
                    Title = "Bob's Important Project"
                },
                new Project
                {
                    Client = context.Clients.Single(c => c.FirstName == "Scott"),
                    StartDate = new DateTime(2015, 10, 15),
                    EndDate = new DateTime(2016, 10, 15),
                    Title = "Some Other Project"
                }
            };
            foreach (var project in projects)
                context.Projects.AddOrUpdate(project);
            context.SaveChanges();

            var invoices = new List<Invoice>
            {
                new Invoice
                {
                    AmountDue = 34000m,
                    DueDate = new DateTime(2016, 12, 31),
                    ProjectID = projects.Single(p =>
                        p.Client == clients.Single(c => c.FirstName == "Dan")).ID
                },
                new Invoice
                {
                    AmountDue = 50000m,
                    DueDate = new DateTime(2016, 12, 31),
                    ProjectID = projects.Single(p =>
                        p.Client == clients.Single(c => c.FirstName == "Bob")).ID
                },
                new Invoice
                {
                    AmountDue = 2000m,
                    DueDate = new DateTime(2016, 12, 31),
                    ProjectID = projects.Single(p =>
                        p.Client == clients.Single(c => c.FirstName == "Scott")).ID
                }
            };
            foreach (var invoice in invoices)
                context.Invoices.AddOrUpdate(invoice);
            context.SaveChanges();
#endif
        }
    }
}
