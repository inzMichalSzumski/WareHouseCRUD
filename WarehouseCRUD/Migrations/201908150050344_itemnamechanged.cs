namespace WarehouseCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemnamechanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "PublicName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "PublicName");
        }
    }
}
