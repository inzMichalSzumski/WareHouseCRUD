namespace WarehouseCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Guid(nullable: false),
                        Name = c.String(),
                        NettoPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BruttoPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Int(nullable: false),
                        WareHouseDocument_WareHouseDocumentId = c.Guid(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.WareHouseDocuments", t => t.WareHouseDocument_WareHouseDocumentId)
                .Index(t => t.WareHouseDocument_WareHouseDocumentId);
            
            CreateTable(
                "dbo.WareHouseDocuments",
                c => new
                    {
                        WareHouseDocumentId = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        ClientNumber = c.Int(nullable: false),
                        DocumentName = c.String(),
                        SumNetto = c.Int(nullable: false),
                        SumBrutto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WareHouseDocumentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "WareHouseDocument_WareHouseDocumentId", "dbo.WareHouseDocuments");
            DropIndex("dbo.Items", new[] { "WareHouseDocument_WareHouseDocumentId" });
            DropTable("dbo.WareHouseDocuments");
            DropTable("dbo.Items");
        }
    }
}
