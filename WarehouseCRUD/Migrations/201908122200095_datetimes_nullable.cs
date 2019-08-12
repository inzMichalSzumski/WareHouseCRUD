namespace WarehouseCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimes_nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WareHouseDocuments", "Created", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WareHouseDocuments", "Created", c => c.DateTime(nullable: false));
        }
    }
}
