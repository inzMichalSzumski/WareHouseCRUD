namespace WarehouseCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_relationship3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WareHouseDocuments", "SumNetto", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.WareHouseDocuments", "SumBrutto", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WareHouseDocuments", "SumBrutto", c => c.Int(nullable: false));
            AlterColumn("dbo.WareHouseDocuments", "SumNetto", c => c.Int(nullable: false));
        }
    }
}
