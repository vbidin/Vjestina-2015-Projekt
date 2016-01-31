namespace SuperSubtitles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ScoreId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SubtitleId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScoreId);
            
            CreateTable(
                "dbo.Subtitles",
                c => new
                    {
                        SubtitleId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        Name = c.String(),
                        Movie = c.String(),
                        Date = c.String(),
                        File = c.Binary(),
                    })
                .PrimaryKey(t => t.SubtitleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subtitles");
            DropTable("dbo.Scores");
        }
    }
}
