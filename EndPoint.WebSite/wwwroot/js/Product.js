
var _productId = $("#product-productId").val();
var _questionPage = 0;
var _commentsPage = 0;
var _endQuestions = false;
var _endComments = false;

//questions
function LoadQuestions(productId, page) {

    var postData = {
        "productId": productId,
        "page": page,
        "take": 1
    };

    $.post("/Question/LoadQuestions", postData, function (data) {

        if (data == null || data.lenght > 0 || data == "") {

            _endQuestions = true;
        } else {
            _questionPage += 1;
            $("#product-questions-list").append(data);
        }
    });

}

function AddQuestion(productId, parentId = null) {
    var text = $("#new-question-text").val();

    var postData = {
        "text": text,
        "productId": productId,
        "parentId": parentId
    };

    $.post("/Question/Add", postData, function (data) {
        if (data.isSuccess) {

            $("#new-question-text").val(null);
            swal.fire(
                'موفق!',
                'پرسش شما با موفقیت ثبت شد و پس از تایید مدیران  در سایت نمایش داه خواهد شد',
                'success'
            );
        } else {
            swal.fire(
                'خطا!',
                data.message,
                'warning'
            );
        }
    });
}

function AddReplay(productId) {
    var questionId = $("#question-id").val();
    var productId = $("#product-id").val();

    AddQuestion(productId, questionId);

    $("#question-id").val(null);
    $("#replay-question-text").text("پرسش خود را در مورد محصول مطرح نمایید");
    $("#question-register-button").text("ثبت پرسش");
    $("#new-question-text").val(null);
    $("#question-register-button").attr("onclick", "AddQuestion(" + productId + ")");
}

function ReplayQuestion(questionId) {
    var QuestionText = $("#question-text-" + questionId).text();
    var productId = $("#product-id").val();
    $("#question-id").val(questionId);
    $("#replay-question-text").text("پاسخ به این پرسش : " + QuestionText);
    $("#question-register-button").text("ثبت پاسخ");
    $("#question-register-button").attr("onclick", "AddReplay(" + productId + ")");
    $("html,body").animate({
        scrollTop: $("#replay-scroll").offset().top
    },
        1000);
}

//comments
function LoadComments(productId, page) {

    var postData = {
        "productId": productId,
        "page": page,
        "take": 1
    };

    $.post("/Comment/LoadComments", postData, function (data) {

        if (data == null || data.lenght > 0 || data == "") {

            _endComments = true;
        } else {
            _commentsPage += 1;
            $(".product-comment-list").append(data);
        }
    });
}

function AddComment(productId) {
    var title = $("#Comment-Title").val();
    var text = $("#Comment-Text").val();
    var recommend = $('input[name=recommend]:checked').val();
    var userRate = $('input[name=rate]:checked').val();
    var postData = {
        'title': title,
        'text': text,
        'IRecommend': recommend,
        'rate': userRate,
        'productId': productId
    };

    var ValidationMessage = CommentValidation(postData);
    if (ValidationMessage == "Valid") {

        $.post("/Comment/Add", postData, function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    'پرسش شما با موفقیت ثبت شد و پس از تایید مدیران  در سایت نمایش داه خواهد شد',
                    'success'
                ).then(function (isConfirm) {
                    $("#Comment-Title").val(null);
                    $("#Comment-Text").val(null);
                    $('input[name=recommend]:checked').prop('checked', false);
                    $('input[name=rate]:checked').prop('checked', false);
                });
            } else {
                swal.fire(
                    'خطا!',
                    'متاسفانه نظر شما ثبت نشد',
                    'warning'
                );
            }
        });

    } else {
        swal.fire(
            'خطا!',
            ValidationMessage,
            'warning'
        );
    }
}

function CommentValidation(postData) {
    if (postData.title == "" || postData.title == null) {
        return "عنوان نظر شما خالی میباشد";
    }
    if (postData.text == "" || postData.text == null) {
        return "متن توضیحات نظر شما خالی میباشد";
    }
    if (postData.IRecommend != "بله" && postData.IRecommend != "خیر") {
        return "بخش پیشنهاد شما برای خرید خالی میباشد";
    }
    if (1 > postData.rate || postData.rate > 5 || postData.rate == undefined) {
        return "لطفا امتیاز خود برای این محصول را ثبت نمایید";
    }
    return "Valid";
}

function LikeComment(productId, commentId) {
    var postData = {
        'productId': productId,
        'commentId': commentId
    };

    $.post("/Comment/LikeComment", postData, function (data) {
        if (data.isSuccess == true) {
            $("#comments" + commentId + "-LikeCount").text(parseInt($("#comments" + commentId + "-LikeCount").text()) + data.data.diffrenceLikes);
            $("#comments" + commentId + "-DislikeCount").text(parseInt($("#comments" + commentId + "-DislikeCount").text()) + data.data.diffrenceDislikes);
        }
    });

}

function DislikeComment(productId, commentId) {
    var postData = {
        'productId': productId,
        'commentId': commentId
    };

    $.post("/Comment/DisLikeComment", postData, function (data) {
        if (data.isSuccess == true) {
            $("#comments" + commentId + "-DislikeCount").text(parseInt($("#comments" + commentId + "-DislikeCount").text()) + data.data.diffrenceDislikes);
            $("#comments" + commentId + "-LikeCount").text(parseInt($("#comments" + commentId + "-LikeCount").text()) + data.data.diffrenceLikes);
        }
    });
}

//Favorite
function AddToFavorite() {

    $.post("/UserPanel/Favorite/AddToFavorite?productId=" + _productId, function (data) {

        if (data.isSuccess) {
            $("#changeFavorite").attr("onclick", "RemoveFromFavorite()");

            $("#changeFavorite").addClass("active");
        }
    });
}

function RemoveFromFavorite() {

    $.post("/UserPanel/Favorite/RemoveFromFavorite?productId=" + _productId, function (data) {

        if (data.isSuccess) {
            $("#changeFavorite").attr("onclick", "AddToFavorite()");

            $("#changeFavorite").removeClass("active");
        }
    });
}


//$("#changeFavorite").on('click', function () {

//    if ($("#changeFavorite").hasClass("active")) {

//        $.post("/UserPanel/Favorite/AddToFavorite?productId=" + _productId, function (data) {

//            if (data.isSuccess) {
//                $("#changeFavorite").removeClass("active");
//            }
//        });
//    } else {

//        $.post("/UserPanel/Favorite/RemoveFromFavorite?productId=" + _productId, function (data) {

//            if (data.isSuccess) {
//                $("#changeFavorite").addClass("active");
//            }
//        });
//    }
//});

//selcetor
function quantitySelector() {
    $('<div class="quantity-nav"><div class="quantity-button quantity-up">+</div><div class="quantity-button quantity-down">-</div></div>').insertAfter('.quantity input');
    $('.quantity').each(function () {
        var spinner = $(this),
            input = spinner.find('input[type="number"]'),
            btnUp = spinner.find('.quantity-up'),
            btnDown = spinner.find('.quantity-down'),
            min = input.attr('min'),
            max = input.attr('max');

        btnUp.click(function () {
            var oldValue = parseFloat(input.val());
            if (oldValue >= max) {
                var newVal = oldValue;
            } else {
                var newVal = oldValue + 1;
            }
            spinner.find("input").val(newVal);
            spinner.find("input").trigger("change");
        });

        btnDown.click(function () {
            var oldValue = parseFloat(input.val());
            if (oldValue <= min) {
                var newVal = oldValue;
            } else {
                var newVal = oldValue - 1;
            }
            spinner.find("input").val(newVal);
            spinner.find("input").trigger("change");
        });
    });
}

$(document).ready(quantitySelector());

$(document).ready(LoadQuestions(_productId, 1));
$(document).ready(LoadComments(_productId, 1));

$(window).scroll(function () {

    if ($(window).scrollTop() == $(document).height() - $(window).height() && !_endQuestions && $("#question-and-answer-tab").hasClass("active")) {

        LoadQuestions(_productId, _questionPage + 1);
    }

    if ($(window).scrollTop() == $(document).height() - $(window).height() && !_endComments && $("#User-comments-tab").hasClass("active")) {

        LoadComments(_productId, _commentsPage + 1);
    }
});

/*
$("#exist-alarm").on('click',
    function () {
        var email = $("#exist-alarm-email").prop('checked');
        var sms = $("#exist-alarm-sms").prop('checked');
        var postData = {
            'productId': _productId,
            'email': email,
            'sms': sms
        };

        console.log(postData);

        $.post("/Product/SetExistAlarm", postData);

        $("#btn-option-alarm").modal('hide');

        $("#exist-alarm-email").prop('checked', false);
        $("#exist-alarm-sms").prop('checked', false);
    }
);

$("#addToCompaire").on('click',
    function () {
     
        var postData = {
            'productId': productId,
        };

        $.post("/Compaire/AddToCompaire", postData,
            function (data) {
                if (data == true) {
                    $("#compaire-snack-bar").html("می توانید لیست مقایسه را از پنل کاربری مشاهده نمایید");
                    $("#compaire-snack-bar").addClass("show");
                    setTimeout(function () {
                        $("#compaire-snack-bar").removeClass("show");
                    }, 5400);
                }
            });

    }
);*/
