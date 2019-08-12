namespace WarehouseCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WareHouseDocuments", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WareHouseDocuments", "Created");
        }
    }
}
