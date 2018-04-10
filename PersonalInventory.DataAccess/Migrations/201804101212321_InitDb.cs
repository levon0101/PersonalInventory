namespace PersonalInventory.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(maxLength: 50),
                        ItemModel = c.String(maxLength: 50),
                        Cost = c.Double(nullable: false),
                        SailPrice = c.Double(nullable: false),
                        ItemDescription = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Item");
        }
    }
}
