$(function () {
    $("#txtPlaceholderSearch").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Home/AutoCompleteArticles",
                type: "POST",
                dataType: "json",
                data: { term: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item.ArticleName,
                            value: item.ArticleURL
                        };
                    }))
                }
            });
        },
        messages: {
            noResults: "", results: ""
        },
        select: function (event, ui) {
            $("#txtPlaceholderSearch").val(ui.item.label);
            window.location.href = ui.item.value;
            return false;
        },
        focus: function (event, ui) {
            event.preventDefault();
            $("#txtPlaceholderSearch").val(ui.item.label);
        }
    });
});