namespace MarketYönetimSistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class somethingsChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyProducts", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "OrderDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "IsDelete", c => c.Boolean(nullable: false));
            DropColumn("dbo.BuyProducts", "İsDelete");
            DropColumn("dbo.Orders", "OrderDateTine");
            DropColumn("dbo.Orders", "İsDelete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "İsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "OrderDateTine", c => c.DateTime(nullable: false));
            AddColumn("dbo.BuyProducts", "İsDelete", c => c.Boolean(nullable: false));
            DropColumn("dbo.Orders", "IsDelete");
            DropColumn("dbo.Orders", "OrderDateTime");
            DropColumn("dbo.BuyProducts", "IsDelete");
        }
    }
}
