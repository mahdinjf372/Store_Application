function LoadComments(questionId, userId, productId, confirmed, fromDate, toDate, pageNumber = 1, takeNumber = 10) {

    var postData = {
        'questionId': questionId,
        'userId': userId,
        'productId': productId,
        'status': confirmed,
        'fromDate': fromDate,
        'toDate': toDate,
        'page': pageNumber,
        'take': takeNumber
    };

    $("#dt-QuestionsData").load("/Admin/Question/LoadQuestions", postData);

    $("#take").val(postData.take);
    $("#page-number").val(postData.page);
    $("#filter-questionId").val(postData.questionId);
    $("#filter-userId").val(postData.userId);
    $("#filter-productId").val(postData.productId);
    $("#filter-fromDate").val(postData.fromDate);
    $("#filter-toDate").val(postData.toDate);
}

function ChangeStatus(questionId) {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var _questionId = $("#filter-questionId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var _confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    var postData = {
        'questionId': questionId
    };
    $.post("/Admin/Question/ChangeStatus", postData,
        function (data) {
            if (data.isSuccess) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                ).then(function (isConfirm) {
                    LoadComments(_questionId, userId, productId, _confirmed, fromDate, toDate, page, take);
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
    var questionId = $("#filter-questionId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    LoadComments(questionId, userId, productId, confirmed, fromDate, toDate, 1, value);
}

function ApplyFilters() {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var questionId = $("#filter-questionId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    LoadComments(questionId, userId, productId, confirmed, fromDate, toDate, 1, take);

}

function onEnter(event) {

    if (event.which == 13) {

        ApplyFilters();
    }
}

$(document).ready(function () {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var questionId = $("#filter-questionId").val();
    var userId = $("#filter-userId").val();
    var productId = $("#filter-productId").val();
    var confirmed = $("#filter-status").val();
    var fromDate = $("#filter-fromDate").val();
    var toDate = $("#filter-toDate").val();

    LoadComments(questionId, userId, productId, confirmed, fromDate, toDate, page, take);
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