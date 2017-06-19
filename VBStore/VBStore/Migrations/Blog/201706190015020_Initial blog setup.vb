Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations.Blog
    Public Partial Class Initialblogsetup
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.BlogPosts",
                Function(c) New With
                    {
                        .PostID = c.Long(nullable := False, identity := True),
                        .AuthorID = c.String(nullable := False),
                        .Content = c.String(nullable := False),
                        .Created = c.DateTime(nullable := False),
                        .Hidden = c.Boolean(nullable := False),
                        .Modified = c.DateTime(nullable := False),
                        .Title = c.String(nullable := False, maxLength := 40)
                    }) _
                .PrimaryKey(Function(t) t.PostID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.BlogPosts")
        End Sub
    End Class
End Namespace
