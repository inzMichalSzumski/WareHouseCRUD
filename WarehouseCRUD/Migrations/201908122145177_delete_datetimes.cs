namespace WarehouseCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_datetimes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WareHouseDocuments", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WareHouseDocuments", "Created", c => c.DateTime(nullable: false));
        }
    }
}
