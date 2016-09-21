namespace CoPlayV2.Migrations.CoPlayDBModelDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditLevelLength1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserSportPerformance", "Level", c => c.String(nullable: false, maxLength: 30, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserSportPerformance", "Level", c => c.String(nullable: false, maxLength: 10, fixedLength: true));
        }
    }
}
