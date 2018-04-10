namespace PersonalInventory.DataAccess.Migrations
{
    using PersonalInventory.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PersonalInventory.DataAccess.PersonalInventoryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PersonalInventory.DataAccess.PersonalInventoryDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Items.AddOrUpdate(
                f => f.ItemName,
                new Item { ItemName = "Arduino Uno", ItemModel = "R3", ItemDescription = "3$", Cost = 3.5, SailPrice = 2300 },
                new Item { ItemName = "Arduino Nano", ItemModel = "R3", ItemDescription = "3$", Cost = 2.9, SailPrice = 2000 },
                new Item { ItemName = "LCD 1602", ItemModel = "1602", ItemDescription = "3$", Cost = 2, SailPrice = 2000 },
                new Item { ItemName = "Usb To TTL", ItemModel = "", ItemDescription = "", Cost = 1, SailPrice = 1000 });
            
        }
    }
}
