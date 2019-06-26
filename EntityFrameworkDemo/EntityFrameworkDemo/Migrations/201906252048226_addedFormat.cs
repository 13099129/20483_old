namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFormat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Format", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Format");
        }
    }
}
