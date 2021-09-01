
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