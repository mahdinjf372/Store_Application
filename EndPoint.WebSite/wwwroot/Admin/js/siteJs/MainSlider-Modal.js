
$("#Create_SlideImage").change(function () {

    Create_readUrl(this);
});
function Create_readUrl(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $("#Create-uploaded-img").attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}


$("#Edit_SlideImage").change(function () {

    Edit_readUrl(this);
});
function Edit_readUrl(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $("#Edit-uploaded-img").attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}