@ModelType VBStore.Blog.BlogPost
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>BlogPost</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.AuthorID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AuthorID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Content)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Content)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Created)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Created)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Hidden)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Hidden)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Modified)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Modified)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Title)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.PostID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
