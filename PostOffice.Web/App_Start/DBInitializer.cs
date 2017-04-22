using System;
using System.Data.Entity;
using PostOffice.Web.Entity;
using PostOffice.Web.Models;

namespace PostOffice.Web.App_Start
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext dbContext)
        {
            var member1 = new Member
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Patronymic = "Ivanovich",
                Address = "Moscow"
            };

            var member2 = new Member
            {
                FirstName = "Petr",
                LastName = "Petrov",
                Patronymic = "Petrovich",
                Address = "Bryansk"
            };

            var member3 = new Member
            {
                FirstName = "Anna",
                LastName = "Petrova",
                Patronymic = "Petrovna",
                Address = "Kaluga"
            };

            var parcel1 = new Parcel
            {
                Weight = 1000,
                Recipient = member1,
                Sender = member2,
                Inventory = "Many-many things"
            };

            var parcel2 = new Parcel
            {
                Weight = 2000,
                Recipient = member1,
                Sender = member3,
                Inventory = "Very few things"
            };

            var parcel3 = new Parcel
            {
                Weight = 300,
                Recipient = member2,
                Sender = member3,
                Inventory = string.Empty
            };

            dbContext.Parcels.Add(parcel1);
            dbContext.Parcels.Add(parcel2);
            dbContext.Parcels.Add(parcel3);

            dbContext.SaveChanges();
        }
    }
}