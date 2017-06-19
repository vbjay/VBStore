Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Blog
    Public Class BlogPost
        <Key>
        <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        Property PostID As Long

        <Required>
        Property AuthorID As String

        <Required>
        Property Content As String
        <Required>
        Property Created As Date = Now
        <Required>
        Property Hidden As Boolean = True
        <Required>
        Property Modified As Date

        <Required>
        <MaxLength(40)>
        Property Title As String
    End Class

End Namespace
