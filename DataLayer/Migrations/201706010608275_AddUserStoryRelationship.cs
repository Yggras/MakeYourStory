namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserStoryRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stories", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Stories", "User_Id");
            AddForeignKey("dbo.Stories", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stories", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Stories", new[] { "User_Id" });
            DropColumn("dbo.Stories", "User_Id");
        }
    }
}
