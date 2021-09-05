
$("#Create_Content").change(function () {
    readUrl_Create(this);
});

function readUrl_Create(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $("#Create_uploaded_img").attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#Edit_Content").change(function () {
    readUrl_Edit(this);
});

function readUrl_Edit(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $("#Edit_uploaded_img").attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

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
kamaDatepicker("Create_StartDate", customOptions);
kamaDatepicker("Create_EndDate", customOptions);
kamaDatepicker("Edit_startDate", customOptions);
kamaDatepicker("Edit_endDate", customOptions);