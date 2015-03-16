namespace StaffTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        AdministratorID = c.Int(nullable: false, identity: true),
                        BirthDay = c.String(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstMidName = c.String(nullable: false, maxLength: 50),
                        HireDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.AdministratorID);
            
            CreateTable(
                "dbo.Behaviors",
                c => new
                    {
                        BehaviorID = c.Int(nullable: false, identity: true),
                        IndividualID = c.Int(nullable: false),
                        StaffID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Antecedant = c.String(nullable: false),
                        Duration = c.Int(nullable: false),
                        Intensity = c.Int(nullable: false),
                        Resolution = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BehaviorID)
                .ForeignKey("dbo.Individuals", t => t.IndividualID, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.IndividualID)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.Individuals",
                c => new
                    {
                        IndividualID = c.Int(nullable: false, identity: true),
                        BirthDay = c.String(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstMidName = c.String(nullable: false, maxLength: 50),
                        EnterDate = c.DateTime(nullable: false),
                        Description = c.String(nullable: false, maxLength: 150),
                        Picture = c.String(),
                        DischargeDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.IndividualID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        BirthDay = c.String(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstMidName = c.String(nullable: false, maxLength: 50),
                        IndividualID = c.Int(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        EmploymentDischarge = c.DateTime(),
                    })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo.Individuals", t => t.IndividualID, cascadeDelete: false)
                .Index(t => t.IndividualID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "IndividualID", "dbo.Individuals");
            DropForeignKey("dbo.Behaviors", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.Behaviors", "IndividualID", "dbo.Individuals");
            DropIndex("dbo.Staffs", new[] { "IndividualID" });
            DropIndex("dbo.Behaviors", new[] { "StaffID" });
            DropIndex("dbo.Behaviors", new[] { "IndividualID" });
            DropTable("dbo.Staffs");
            DropTable("dbo.Individuals");
            DropTable("dbo.Behaviors");
            DropTable("dbo.Administrators");
        }
    }
}
