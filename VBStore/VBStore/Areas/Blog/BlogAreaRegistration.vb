Imports System.Web.Mvc

Namespace Areas.Blog
    Public Class BlogAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "Blog"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As AreaRegistrationContext)
            context.MapRoute(
                "Blog_default",
                "Blog/{controller}/{action}/{id}",
                New With {.action = "Index", .id = UrlParameter.Optional, .controller = "Home"},
                namespaces:={"VBStore.Areas.Blog.Controllers"}
            )
        End Sub
    End Class
End Namespace