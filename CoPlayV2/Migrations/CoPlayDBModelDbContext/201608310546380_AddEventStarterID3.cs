namespace CoPlayV2.Migrations.CoPlayDBModelDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventStarterID3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "UserID", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "UserID");
        }
    }
}
