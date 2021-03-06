﻿$(document).ready(function () {
    $('#contact-submit').click(function (e) {
        e.preventDefault();
        if ($(this).parents('form').valid()) {
            var data = $(this).parents('form').serialize();
            var apiurl = $(this).data('action')
            $.ajax({
                type: 'POST',
                url: apiurl,
                data: data,
                success: function (result) {
                    if (result.Success) {
                        $("#response-error").css("display", "none");
                        $("#response").css("display", "block");
                        $('#response span.number').text(result.Data.NumberToWord);
                        $('#response span.name').text(result.Data.Name);
                    }
                    else {
                        $("#response").css("display", "none");
                        $("#response-error").css("display", "block");
                        $('#response-error label.somethingwentwrong').text(result.ErrorCode + " : " + result.ErrorMessage)
                        $('#response').addClass('hide');
                    }
                    $('.overlay').hide();
                },
                error: function (result) {
                    $("#response").css("display", "none");
                    $("#response-error").css("display", "block");
                    $('#response-error label.somethingwentwrong').text("Oops! Something went wrong. Please try again")
                    $('#response').addClass('hide')
                }
            });
        }
    });
});