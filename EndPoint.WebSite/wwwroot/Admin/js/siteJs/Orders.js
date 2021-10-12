function LoadOrders(orderId, userId, state, fromDateOrder, toDateOrder, fromDatePay, toDatePay, pageNumber = 1, takeNumber = 10) {

    var postData = {
        'orderId': orderId,
        'userId': userId,
        'state': state,
        'fromDateOrder': fromDateOrder,
        'toDateOrder': toDateOrder,
        'fromDatePay': fromDatePay,
        'toDatePay': toDatePay,
        'page': pageNumber,
        'take': takeNumber
    };

    $("#dt-OrdersData").load("/Admin/Order/LoadOrders", postData);

    $("#take").val(postData.take);
    $("#page-number").val(postData.page);
    $("#filter-orderId").val(postData.orderId);
    $("#filter-userId").val(postData.userId);
    $("#filter-fromDateOrder").val(postData.fromDateOrder);
    $("#filter-toDateOrder").val(postData.toDateOrder);
    $("#filter-fromDatePay").val(postData.fromDatePay);
    $("#filter-toDatePay").val(postData.toDatePay);
}

function TakeNumberChanged(value) {

    $("#take").val(value);
    var orderId = $("#filter-orderId").val();
    var userId = $("#filter-userId").val();
    var state = $("#filter-state").val();
    var fromDateOrder = $("#filter-fromDateOrder").val();
    var toDateOrder = $("#filter-toDateOrder").val();
    var fromDatePay = $("#filter-fromDatePay").val();
    var toDatePay = $("#filter-toDatePay").val();

    LoadOrders(orderId, userId, state, fromDateOrder, toDateOrder, fromDatePay, toDatePay, 1, value);
}

function ApplyFilters() {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var orderId = $("#filter-orderId").val();
    var userId = $("#filter-userId").val();
    var state = $("#filter-state").val();
    var fromDateOrder = $("#filter-fromDateOrder").val();
    var toDateOrder = $("#filter-toDateOrder").val();
    var fromDatePay = $("#filter-fromDatePay").val();
    var toDatePay = $("#filter-toDatePay").val();

    LoadOrders(orderId, userId, state, fromDateOrder, toDateOrder, fromDatePay, toDatePay, 1, take);
}

function onEnter(event) {

    if (event.which == 13) {

        ApplyFilters();
    }
}

$(document).ready(function () {

    var page = $("#page-number").val();
    var take = $("#take").val();
    var orderId = $("#filter-orderId").val();
    var userId = $("#filter-userId").val();
    var state = $("#filter-state").val();
    var fromDateOrder = $("#filter-fromDateOrder").val();
    var toDateOrder = $("#filter-toDateOrder").val();
    var fromDatePay = $("#filter-fromDatePay").val();
    var toDatePay = $("#filter-toDatePay").val();

    LoadOrders(orderId, userId, state, fromDateOrder, toDateOrder, fromDatePay, toDatePay, page, take);
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
kamaDatepicker("filter-fromDateOrder", customOptions);
kamaDatepicker("filter-toDateOrder", customOptions);
kamaDatepicker("filter-fromDatePay", customOptions);
kamaDatepicker("filter-toDatePay", customOptions);
