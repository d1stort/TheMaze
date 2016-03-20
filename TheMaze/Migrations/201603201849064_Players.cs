namespace TheMaze.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Players : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "NickName", c => c.String(nullable: false));
            DropColumn("dbo.Players", "Name");
            DropColumn("dbo.Players", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Rating", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Players", "NickName");
        }
    }
}
