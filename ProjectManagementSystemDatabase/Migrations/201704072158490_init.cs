namespace ProjectManagementSystemDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 12, storeType: "nvarchar"),
                        ShortName = c.String(maxLength: 15, storeType: "nvarchar"),
                        Name = c.String(maxLength: 120, storeType: "nvarchar"),
                        Description = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
