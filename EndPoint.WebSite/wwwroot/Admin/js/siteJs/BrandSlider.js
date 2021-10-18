

function LoadBrands() {

    $.ajaxSetup({ method: "get" });
    $("#dt-FeaturesData").load("/Admin/BrandSlider/LoadSlides");
}

function ShowCreateModal() {

    $("#Create_uploaded_img").val(null);
    $("#Create_title").val(null);
    $("#Create_Content").val(null);
    $("#Create_SlideLink").val('http://');

    $("#CreateModal").modal('show');
}

function Create() {

    var title = $("#Create_title").val();
    var link = $("#Create_SlideLink").val();
    var image = document.getElementById("Create_Content").files[0];


    var postData = new FormData();
    postData.append("title", title);
    postData.append("linkTo", link);
    postData.append("image", image);
    postData.append("imageName", "default.jpg");

    $.ajax({
        contentType: false,
        processData: false,
        url: '/Admin/BrandSlider/Create',
        type: 'POST',
        data: postData,
        dataType: 'json',
        success: function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                ).then(function () {

                    $("#CreateModal").modal('hide');
                    LoadBrands();
                });
            } else {
                swal.fire(
                    'خطا!',
                    data.message,
                    'warning'
                );
            }
        }
    });
}

function Delete(brandId) {
    swal.fire({
        title: 'حذف  تصویر',
        text: 'آیا از حذف این بنر مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            $.post("/Admin/BrandSlider/Delete/" + brandId,
                function (data) {
                    if (data.isSuccess == true) {
                        swal.fire(
                            'موفق!',
                            data.message,
                            'success'
                        ).then(function (isConfirm) {

                            $("#Brand" + brandId).hide(1000);
                        });
                    } else {
                        swal.fire(
                            'خطا!',
                            data.message,
                            'warning'
                        );
                    }
                }
            );
        }
    });
}

$(document).ready(LoadBrands());
