function RemoveQuestion(questionId) {

    var postData = {
        "questionId": questionId
    };

    $.post("/UserPanel/Question/RemoveQuestion", postData, function (data) {

        if (data.isSuccess) {

            $(".question-" + questionId).hide("slow");
        }
    });
}