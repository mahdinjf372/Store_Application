
function ShowCreateSlideModal() {

    $("#CreateSlideModal").modal('show');
}

function CreateSlide() {
    var slideName = $("#Create_SlideName").val();
    var slideLink = $("#Create_SlideLink").val();
    var slideImage = document.getElementById("Create_SlideImage").files[0];

    var formData = new FormData();

    formData.append("image", slideImage);
    formData.append("imageName", "default.jpg");
    formData.append("title", slideName);
    formData.append("linkTo", slideLink);

    $.ajax({
        contentType: false,
        processData: false,
        url: '/Admin/MainSlider/Create',
        type: 'POST',
        data: formData,
        dataType: 'json',
        success: function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                ).then(function () {

                    location.reload();
                });
            } else {
                swal.fire(
                    'ناموفق!',
                    data.message,
                    'warning'
                );
            }
        }
    });
}

function ShowEditSlideModal(slideId, title, imageName, linkTo) {
    $("#Edit_SlideId").val(slideId);
    $("#Edit_SlideName").val(title);
    $("#Edit_SlideLink").val(linkTo);
    $("#Edit_SlideImageName").val(imageName);
    $("#Edit-uploaded-img").attr('src', "/images/slider-main/" + imageName);

    $("#EditSlideModal").modal('show');
}

function EditSlide() {
    var Id = $("#Edit_SlideId").val();
    var Name = $("#Edit_SlideName").val();
    var Link = $("#Edit_SlideLink").val();
    var OldImageName = $("#Edit_SlideImageName").val();
    var Image = document.getElementById("Edit_SlideImage").files[0];

    var formData = new FormData();

    formData.append("id", Id);
    formData.append("title", Name);
    formData.append("imageName", OldImageName);
    formData.append("linkTo", Link);
    formData.append("image", Image);

    $.ajax({
        contentType: false,
        processData: false,
        url: '/Admin/MainSlider/Edit',
        type: 'POST',
        data: formData,
        dataType: 'json',
        success: function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                ).then(function () {

                    location.reload();
                });
            } else {
                swal.fire(
                    'ناموفق!',
                    data.message,
                    'warning'
                );
            }
        }
    });
}

function DeleteSlide(slideId, title) {
    swal.fire({
        title: 'حذف  ویژگی',
        text: 'آیا از حذف اسلاید با نام' + '" ' + title + ' "' + 'مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'id': slideId
            };

            $.post("/Admin/MainSlider/Delete", postData, function (data) {

                if (data.isSuccess == true) {
                    swal.fire(
                        'موفق!',
                        data.message,
                        'success'
                    ).then(function () {

                        location.reload();
                    });
                } else {
                    swal.fire(
                        'ناموفق!',
                        data.message,
                        'warning'
                    );
                }
            });
        }
    });
}

function MainSliderImageLink(slideId) {
    var slideLink = $("#MainSlider-Slide" + slideId + "-input").val();
    window.open(slideLink);
}