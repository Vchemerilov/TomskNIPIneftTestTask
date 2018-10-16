namespace SectionData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                        Name = c.String(),
                        City = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.SectionEntities");
        }
        
        public override void Down()
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
            
            DropTable("dbo.Sections");
        }
    }
}
