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

$(document).ready(function () {
    $('#typed-strings').hide();
});


$(function () {
    $("#typed").typed({
        stringsElement: $('#typed-strings'),
        typeSpeed: 30,
        backDelay: 500,
        loop: true,
        contentType: 'html',
        loopCount: false,
        callback: function () { callbackfunc(); },
        resetCallback: function () { newTyped(); }
    });

    $(".reset").click(function () {
        $("#typed").typed('reset');
    });

});


function newTyped() { /* A new typed object */ }

function callbackfunc() { console.log("Callback"); }

/// Book Search

$(document).ready(function () {
    $('#SearchTerm').focus();
});

$(function () {
    $("input").keydown(function (e) {
        if (e.keyCode == 13) {
            $("#loading").fadeIn();
        }
    });
});

/// Xamarin

$(document).ready(function () {
    $('#xamarinsearch').focus();
});

$(function () {
    var $rows = $('#xamarintable tr');
    $('#xamarinsearch').keyup(function () {

        var val = '^(?=.*\\b' + $.trim($(this).val()).split(/\s+/).join('\\b)(?=.*\\b') + ').*$',
            reg = RegExp(val, 'i'),
            text;

        $rows.show().filter(function () {
            text = $(this).text().replace(/\s+/g, ' ');
            return !reg.test(text);
        }).hide();
    });
});


//Entity Framework

$(document).ready(function () {
    $('#Efsearch').focus();
});
$(function () {
    var $rows = $('#eftable tr');
    $('#Efsearch').keyup(function () {

        var val = '^(?=.*\\b' + $.trim($(this).val()).split(/\s+/).join('\\b)(?=.*\\b') + ').*$',
            reg = RegExp(val, 'i'),
            text;

        $rows.show().filter(function () {
            text = $(this).text().replace(/\s+/g, ' ');
            return !reg.test(text);
        }).hide();
    });
});

//// MVC

$(document).ready(function () {
    $('#mvcsearch').focus();
});

$(function () {

    var $rows = $('#mvctable tr');
    $('#mvcsearch').keyup(function () {

        var val = '^(?=.*\\b' + $.trim($(this).val()).split(/\s+/).join('\\b)(?=.*\\b') + ').*$',
            reg = RegExp(val, 'i'),
            text;

        $rows.show().filter(function () {
            text = $(this).text().replace(/\s+/g, ' ');
            return !reg.test(text);
        }).hide();
    });
});