
var ViewBag = {
    productId: ""
};

ViewBag.productId = $("#product-productId").val();


$("#changeFavorite").on('click',
    function () {
        $.get("/Product/ChangeUserFavorite/?productId=" + ViewBag.productId,
            function (data) {

                if (data == true) {
                    $("#changeFavorite").addClass("active");
                } else if (data == false) {
                    $("#changeFavorite").removeClass("active");
                }
            });
    }
);

$("#exist-alarm").on('click',
    function () {
        var email = $("#exist-alarm-email").prop('checked');
        var sms = $("#exist-alarm-sms").prop('checked');
        var postData = {
            'productId': ViewBag.productId,
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

/*
$("#addToCompaire").on('click',
    function () {
       
        var postData = {
            'productId': ViewBag.productId,
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


function LoadQuestions(productId) {
    $("#product-questions-list").load("/Product/Questions/" + productId);
}

function AddQuestion(productId) {
    var text = $("#new-question-text").val();

    var postData = {
        "text": text,
        "productId": productId
    };

    $.ajax({
        url: "/Product/Question/Add",
        type: "post",
        data: postData,
        success: function (data) {
            if (data == true) {
                swal.fire(
                    'موفق!',
                    'پرسش شما با موفقیت ثبت شد',
                    'success'
                ).then(function (isConfirm) {
                    LoadQuestions(productId);
                    $("#new-question-text").val(null);
                });
            } else {
                swal.fire(
                    'خطا!',
                    'متاسفانه پرسش شما ثبت نشد',
                    'warning'
                ).then(function (isConfirm) {
                    $("#new-question-text").val(null);
                });
            }
        }
    });
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

function AddReplay(productId) {
    var text = $("#new-question-text").val();
    var questionId = $("#question-id").val();
    var postData = {
        "text": text,
        "productId": productId,
        "parentId": questionId
    };

    $.ajax({
        url: "/Product/Question/Edit",
        type: "post",
        data: postData,
        success: function (data) {
            if (data == true) {
                swal.fire(
                    'موفق!',
                    'پاسخ شما با موفقیت ثبت شد',
                    'success'
                ).then(function (isConfirm) {
                    $("#question-id").val(null);
                    $("#replay-question-text").text("پرسش خود را در مورد محصول مطرح نمایید");
                    $("#question-register-button").text("ثبت پرسش");
                    $("#new-question-text").val(null);
                    $("#question-register-button").attr("onclick", "AddQuestion(" + productId + ")");
                    LoadQuestions(productId);
                });
            } else {
                swal.fire(
                    'خطا!',
                    'متاسفانه پاسخ شما ثبت نشد',
                    'warning'
                ).then(function (isConfirm) {
                    $("#question-id").val(null);
                    $("#replay-question-text").text("پرسش خود را در مورد محصول مطرح نمایید");
                    $("#question-register-button").text("ثبت پرسش");
                    $("#new-question-text").val(null);
                    $("#question-register-button").attr("onclick", "AddQuestion(" + productId + ")");
                });
            }
        }
    });
}


function LoadComments(productId) {
    $(".product-comment-list").load("/Product/Comments/" + productId);
}

function AddComment(productId) {
    var title = $("#Comment-Title").val();
    var text = $("#Comment-Text").val();
    var recommend = $('input[name=recommend]:checked').val();
    var userRate = $('input[name=rate]:checked').val();
    var postData = {
        'title': title,
        'text': text,
        'recommend': recommend,
        'rate': userRate,
        'productId': productId
    };
    var ValidationMessage = CommentValidation(postData);
    if (ValidationMessage == "Valid") {
        $.ajax({
            url: "/Product/Comments/Add",
            type: "post",
            data: postData,
            success: function (data) {
                if (data == true) {
                    swal.fire(
                        'موفق!',
                        'نظر شما با موفقیت ثبت شد',
                        'success'
                    ).then(function (isConfirm) {
                        $("#Comment-Title").val(null);
                        $("#Comment-Text").val(null);
                        $('input[name=recommend]:checked').prop('checked', false);
                        $('input[name=rate]:checked').prop('checked', false);
                        LoadComments(productId);
                    });
                } else {
                    swal.fire(
                        'خطا!',
                        'متاسفانه نظر شما ثبت نشد',
                        'warning'
                    );
                }
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
    if (postData.recommend != "بله" && postData.recommend != "خیر") {
        return "بخش پیشنهاد شما برای خرید خالی میباشد";
    }
    if (1 > postData.rate || postData.rate > 5 || postData.rate == undefined) {
        return "لطفا امتیاز خود برای این محصول را ثبت نمایید";
    }
    return "Valid";
}

function LikeComment(commentId) {
    var postData = {
        'commentId': commentId
    };

    $.ajax({
        url: "/Product/Comments/Like",
        type: "post",
        data: postData,
        success: function (data) {
            if (data == true) {
                $("#comments" + commentId + "-LikeCount").text(parseInt($("#comments" + commentId + "-LikeCount").text()) + 1);
            }
        }
    });
}

function DislikeComment(commentId) {
    var postData = {
        'commentId': commentId
    };

    $.ajax({
        url: "/Product/Comments/Dislike",
        type: "post",
        data: postData,
        success: function (data) {
            if (data == true) {
                $("#comments" + commentId + "-DislikeCount").text(parseInt($("#comments" + commentId + "-DislikeCount").text()) + 1);
            }
        }
    });
}





$(document).ready(LoadQuestions(ViewBag.productId));
$(document).ready(LoadComments(ViewBag.productId));

