namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReworkingDatabaseModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Stories", name: "User_Id", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.Stories", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            DropPrimaryKey("dbo.Stories");
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        ApplicationUser_Id = c.String(maxLength: 128),
                        Token_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Token_Id)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Token_Id);
            
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        LineId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Story_StoryId = c.Int(),
                    })
                .PrimaryKey(t => t.LineId)
                .ForeignKey("dbo.Stories", t => t.Story_StoryId)
                .Index(t => t.Story_StoryId);
            
            AddColumn("dbo.Stories", "StoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Stories", "Title", c => c.String());
            AddColumn("dbo.AspNetUsers", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Game_GameId", c => c.Int());
            AddPrimaryKey("dbo.Stories", "StoryId");
            CreateIndex("dbo.AspNetUsers", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUsers", "Game_GameId");
            CreateIndex("dbo.Stories", "StoryId");
            AddForeignKey("dbo.AspNetUsers", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Stories", "StoryId", "dbo.Games", "GameId");
            AddForeignKey("dbo.AspNetUsers", "Game_GameId", "dbo.Games", "GameId");
            DropColumn("dbo.Stories", "Id");
            DropColumn("dbo.Stories", "StoryContent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stories", "StoryContent", c => c.String());
            AddColumn("dbo.Stories", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Games", "Token_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Game_GameId", "dbo.Games");
            DropForeignKey("dbo.Lines", "Story_StoryId", "dbo.Stories");
            DropForeignKey("dbo.Stories", "StoryId", "dbo.Games");
            DropForeignKey("dbo.AspNetUsers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Games", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Lines", new[] { "Story_StoryId" });
            DropIndex("dbo.Stories", new[] { "StoryId" });
            DropIndex("dbo.AspNetUsers", new[] { "Game_GameId" });
            DropIndex("dbo.AspNetUsers", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Games", new[] { "Token_Id" });
            DropIndex("dbo.Games", new[] { "ApplicationUser_Id" });
            DropPrimaryKey("dbo.Stories");
            DropColumn("dbo.AspNetUsers", "Game_GameId");
            DropColumn("dbo.AspNetUsers", "ApplicationUser_Id");
            DropColumn("dbo.Stories", "Title");
            DropColumn("dbo.Stories", "StoryId");
            DropTable("dbo.Lines");
            DropTable("dbo.Games");
            AddPrimaryKey("dbo.Stories", "Id");
            RenameIndex(table: "dbo.Stories", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Stories", name: "ApplicationUser_Id", newName: "User_Id");
        }
    }
}
