namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateorg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Account = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 200),
                        Telphone = c.String(nullable: false, maxLength: 50),
                        Mobile = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 100),
                        Permission = c.String(maxLength: 100),
                        Org_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orgs", t => t.Org_Id)
                .Index(t => t.Org_Id);
            
            CreateTable(
                "dbo.Orgs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        InitDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Org_Id", "dbo.Orgs");
            DropIndex("dbo.Members", new[] { "Org_Id" });
            DropTable("dbo.Orgs");
            DropTable("dbo.Members");
        }
    }
}
