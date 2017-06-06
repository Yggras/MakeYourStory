namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMaxLinePropertyToGameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "MaxLines", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "MaxLines");
        }
    }
}
