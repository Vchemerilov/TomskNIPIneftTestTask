namespace SectionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SectionEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Section = c.String(),
                        Name = c.String(),
                        City = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SectionEntities");
        }
    }
}
