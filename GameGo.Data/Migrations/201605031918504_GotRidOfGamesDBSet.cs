namespace GameGo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GotRidOfGamesDBSet : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Game");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Game",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        GameRating = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        Earnings = c.Int(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.GameId);
            
        }
    }
}
