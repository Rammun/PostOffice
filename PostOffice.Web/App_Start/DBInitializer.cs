using System.Data.Entity;
using PostOffice.Web.Entity;
using PostOffice.Web.Models;

namespace PostOffice.Web.App_Start
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext dbContext)
        {
            var parcel1 = new Parcel
            {
                Weight = 1000,
                RecipientFio = "Ruslan",
                SenderFio = "Alex",
                RecipAdress = "Bryansk",
                SendAdress = "Moscow"
            };

            parcel1.Inventory.Add(new Thing { Name = "A" });
            parcel1.Inventory.Add(new Thing { Name = "B" });
            parcel1.Inventory.Add(new Thing { Name = "C" });

            var parcel2 = new Parcel
            {
                Weight = 2000,
                RecipientFio = "Ivan",
                SenderFio = "Petr",
                RecipAdress = "Moscow",
                SendAdress = "Bryansk"
            };

            parcel2.Inventory.Add(new Thing { Name = "D" });
            parcel2.Inventory.Add(new Thing { Name = "I" });
            parcel2.Inventory.Add(new Thing { Name = "F" });

            dbContext.Parcels.Add(parcel1);
            dbContext.Parcels.Add(parcel2);

            dbContext.SaveChanges();
        }
    }
}