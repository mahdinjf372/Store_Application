
function LoadComments(commentId, userId, productId, confirmed, fromDate, toDate, pageNumber = 1, takeNumber = 10) {

    var postData = {
        'commentId': commentId,
        'userId': userId,
        'productId': productId,
        'status': confirmed,
        'fromDate': fromDate,
        'toDate': toDate,
        'page': pageNumber,
        'take': takeNumber
    };

    $("#dt-CommentsData").load("/Admin/Comment/LoadComments", postData);

    $("#take").val(postData.take);
    $("#page-number").val(postData.page);
    $("#filter-commentId").val(postData.commentId);
    $("#filter-userId").val(postData.userId);
    $("#filter-productId").val(postData.productId);
    //$("#filter-status").val();
    $("#filter-fromDate").val(postData.fromDate);
    $("#filter-toDate").val(postData.toDate);
}

function ChangeStatus(commentId) {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var _commentId = $("#filter-commentId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var _confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    var postData = {
        'commentId': commentId
    };
    $.post("/Admin/Comment/ChangeStatus", postData,
        function (data) {
            if (data.isSuccess) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                ).then(function (isConfirm) {
                    LoadComments(_commentId, userId, productId, _confirmed, fromDate, toDate, page, take);
                });
            }
            else {
                swal.fire(
                    'خطا!',
                    data.message,
                    'warning'
                );
            }
        });
}

function TakeNumberChanged(value) {

    $("#take").val(value);
    var commentId = $("#filter-commentId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    LoadComments(commentId, userId, productId, confirmed, fromDate, toDate, 1, value);
}

function ApplyFilters() {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var commentId = $("#filter-commentId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    LoadComments(commentId, userId, productId, confirmed, fromDate, toDate, 1, take);

}

function onEnter(event) {

    if (event.which==13) {

        ApplyFilters();
    }
}

$(document).ready(function () {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var commentId = $("#filter-commentId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    LoadComments(commentId, userId, productId, confirmed, fromDate, toDate, page, take);
});



var customOptions = {
    placeholder: "روز / ماه / سال"
    , twodigit: false
    , closeAfterSelect: false
    , nextButtonIcon: "fa fa-arrow-circle-right"
    , previousButtonIcon: "fa fa-arrow-circle-left"
    , buttonsColor: "blue"
    , forceFarsiDigits: true
    , markToday: true
    , markHolidays: true
    , highlightSelectedDay: true
    , sync: true
    , gotoToday: true
}
kamaDatepicker("filter-toDate", customOptions);
kamaDatepicker("filter-fromDate", customOptions);
