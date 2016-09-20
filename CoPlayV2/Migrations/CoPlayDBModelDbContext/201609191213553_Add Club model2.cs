namespace CoPlayV2.Migrations.CoPlayDBModelDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClubmodel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClubModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        SportType = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        Address = c.String(),
                        Contact = c.String(),
                        TraningTime = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClubModels");
        }
    }
}
