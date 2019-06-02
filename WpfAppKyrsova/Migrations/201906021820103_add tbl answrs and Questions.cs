namespace WpfAppKyrsova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtblanswrsandQuestions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblQuestions");
            DropTable("dbo.tblAnswers");
        }
    }
}
