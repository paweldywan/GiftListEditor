namespace GiftListEditor.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        ELId = c.Int(nullable: false, identity: true),
                        ErrorType = c.String(),
                        Message = c.String(),
                        ErrorMessage = c.String(),
                        StackTrace = c.String(),
                        LogLevel = c.Int(nullable: false),
                        RequestUri = c.String(),
                        MachineName = c.String(),
                        DateModified = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ELId);
            
            CreateTable(
                "dbo.File",
                c => new
                    {
                        ALLFId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Extension = c.String(),
                        RefId = c.Int(nullable: false),
                        RefGid = c.Int(nullable: false),
                        Description = c.String(),
                        GroupId = c.Int(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ALLFId);
            
            CreateTable(
                "dbo.Mail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Folder = c.Int(nullable: false),
                        From = c.String(nullable: false, maxLength: 150),
                        To = c.String(nullable: false, maxLength: 150),
                        Subject = c.String(nullable: false, maxLength: 150),
                        Date = c.DateTimeOffset(nullable: false, precision: 7),
                        MessageContent = c.String(nullable: false, maxLength: 2500),
                        DateModified = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mail");
            DropTable("dbo.File");
            DropTable("dbo.Log");
        }
    }
}
