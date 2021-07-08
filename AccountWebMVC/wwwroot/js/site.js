// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    $(function () {
        $("#Teste").click(function () {
            $("#modal").load("/Local/TesteModal/", function () {
                $("#modal").modal();
            })
        });

        });

        $(function () {
        $(".local").click(function () {
            $("#modal2").load("/Local/Create/", function () {
                $("#modal2").modal();
            })
        })
    });