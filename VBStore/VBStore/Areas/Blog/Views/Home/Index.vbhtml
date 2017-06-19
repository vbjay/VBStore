@ModelType IEnumerable(Of VBStore.Blog.BlogPost)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.AuthorID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Content)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Created)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Hidden)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Modified)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Title)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AuthorID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Content)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Created)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Hidden)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Modified)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Title)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PostID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PostID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PostID })
        </td>
    </tr>
Next

</table>
