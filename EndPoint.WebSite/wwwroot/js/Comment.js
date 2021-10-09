function RemoveComment(commentId) {

    var postData = {
        "commentId": commentId
    };

    $.post("/UserPanel/Comment/RemoveComment",postData,function(data) {

        if (data.isSuccess) {

            $(".comment-" + commentId).hide("slow");
        }
    });
}