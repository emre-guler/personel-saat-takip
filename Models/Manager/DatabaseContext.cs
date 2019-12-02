using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication23.Models.Manager
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Clock> Clocks { get; set; }
        public DatabaseContext()
        {
            Database.SetInitializer(new CreateDatabase());
        }
    }
    public class CreateDatabase : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            string[] person = {"Emre Güler","Ayhan Dorman","Yiğit Ersoylu","Yiğit Yakut","Serdar Karaca"};
            for (int i = 0; i < person.Length; i++)
            {
                Person pers = new Person();
                pers.Fullname = person[i];
                context.Persons.Add(pers);
            }
            context.SaveChanges();
        }
    }
}