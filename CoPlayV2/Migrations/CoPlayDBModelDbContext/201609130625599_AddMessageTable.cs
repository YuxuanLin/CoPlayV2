namespace CoPlayV2.Migrations.CoPlayDBModelDbContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMessageTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InternalMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenderID = c.String(nullable: false, maxLength: 128),
                        ReceiverID = c.String(nullable: false, maxLength: 128),
                        Status = c.Int(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InternalMessages");
        }
    }
}
