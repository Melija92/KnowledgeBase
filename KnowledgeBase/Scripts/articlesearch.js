/* Open when someone clicks on the span element */
function openArticles() {
    document.getElementById("articleNav").style.width = "100%";
    $('#search').focus();
    $('#table').hide();
}

/* Close when someone clicks on the "x" symbol inside the overlay */
function closeArticles() {
    document.getElementById("articleNav").style.width = "0%";
}

$(function () {
    $('#search').keyup(function () {
        if ($('#search').val() == '')
        { $('#table').hide(); }
        else {
            $('#table').show();
            var $rows = $('#table tr');
            var val = '^(?=.*\\b' + $.trim($(this).val()).split(/\s+/).join('\\b)(?=.*\\b') + ').*$',
                reg = RegExp(val, 'i'),
                text;
            $rows.show().filter(function () {
                text = $(this).text().replace(/\s+/g, ' ');
                return !reg.test(text);
            }).hide();
        }
    });
});