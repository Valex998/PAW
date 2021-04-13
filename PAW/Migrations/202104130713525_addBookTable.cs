namespace PAW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBookTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookTitle = c.String(),
                        BookContent = c.String(),
                        BookDateAdded = c.DateTime(nullable: false),
                        ReadingDuration = c.String(),
                        BookImage = c.String(),
                        FieldId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fields", t => t.FieldId, cascadeDelete: true)
                .Index(t => t.FieldId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "FieldId", "dbo.Fields");
            DropIndex("dbo.Books", new[] { "FieldId" });
            DropTable("dbo.Books");
        }
    }
}
