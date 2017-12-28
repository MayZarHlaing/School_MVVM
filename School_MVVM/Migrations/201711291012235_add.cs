namespace School_MVVM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        Course_CourseId = c.Int(),
                        Standard_StandardId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .ForeignKey("dbo.Standards", t => t.Standard_StandardId)
                .Index(t => t.Course_CourseId)
                .Index(t => t.Standard_StandardId);
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StandardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Standard_StandardId", "dbo.Standards");
            DropForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Standard_StandardId" });
            DropIndex("dbo.Students", new[] { "Course_CourseId" });
            DropTable("dbo.Standards");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
