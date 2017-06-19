Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports VBStore.Blog

Namespace Areas.Blog.Controllers
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        Private db As New BlogContext

        ' GET: Blog/
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.Posts.ToListAsync())
        End Function

        ' GET: Blog/Details/5
        Async Function Details(ByVal id As Long?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim blogPost As BlogPost = Await db.Posts.FindAsync(id)
            If IsNothing(blogPost) Then
                Return HttpNotFound()
            End If
            Return View(blogPost)
        End Function

        ' GET: Blog/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Blog/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="PostID,AuthorID,Content,Created,Hidden,Modified,Title")> ByVal blogPost As BlogPost) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Posts.Add(blogPost)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(blogPost)
        End Function

        ' GET: Blog/Edit/5
        Async Function Edit(ByVal id As Long?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim blogPost As BlogPost = Await db.Posts.FindAsync(id)
            If IsNothing(blogPost) Then
                Return HttpNotFound()
            End If
            Return View(blogPost)
        End Function

        ' POST: Blog/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="PostID,AuthorID,Content,Created,Hidden,Modified,Title")> ByVal blogPost As BlogPost) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(blogPost).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(blogPost)
        End Function

        ' GET: Blog/Delete/5
        Async Function Delete(ByVal id As Long?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim blogPost As BlogPost = Await db.Posts.FindAsync(id)
            If IsNothing(blogPost) Then
                Return HttpNotFound()
            End If
            Return View(blogPost)
        End Function

        ' POST: Blog/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Long) As Task(Of ActionResult)
            Dim blogPost As BlogPost = Await db.Posts.FindAsync(id)
            db.Posts.Remove(blogPost)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
