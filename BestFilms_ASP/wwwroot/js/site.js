// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.btn-view-details').click(function (e) {
        e.preventDefault();
        var filmId = $(this).data('film-id');
        var url = '/Films/Details/' + filmId;

        $.get(url, function (data) {
            $('#filmDetailsModal .modal-body').html(data);
            $('#filmDetailsModal').modal('show');
        }).fail(function () {
            alert('Не удалось загрузить информацию о фильме.');
        });
    });
});
