namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendeeID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendeeID })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId)
                .Index(t => t.AttendeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Attendances", "AttendeeID", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "AttendeeID" });
            DropIndex("dbo.Attendances", new[] { "CourseId" });
            DropTable("dbo.Attendances");
        }
    }
}
