namespace SuperSubtitles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subtitles",
                c => new
                    {
                        SubtitleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Movie = c.String(),
                    })
                .PrimaryKey(t => t.SubtitleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subtitles");
        }
    }
}
