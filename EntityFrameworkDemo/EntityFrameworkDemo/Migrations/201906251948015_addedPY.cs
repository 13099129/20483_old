namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPY : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PublishYear", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "PublishYear");
        }
    }
}
