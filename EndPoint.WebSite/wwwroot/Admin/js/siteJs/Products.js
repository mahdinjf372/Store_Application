
function LoadProducts(searchKey = "", page = 1, takeNumber = 10) {

    var postData = {
        'page': page,
        'searchKey': searchKey,
        'take': takeNumber
    };

    $("#dt-Products").load("/Admin/Product/LoadProducts", postData);
}

function DeleteProduct(title, id) {

    swal.fire({
        title: 'حذف  محصول',
        text: 'آیا از حذف' + '" ' + title + ' "' + 'مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'id': id
            };

            $.post("/Admin/Product/DeleteProduct", postData, function (data) {
                if (data != false) {
                    swal.fire(
                        'موفق',
                        data.Message,
                        'success'
                    );

                } else {
                    swal.fire(
                        'ناموفق',
                        "حذف محصول با شکست مواجه شد",
                        'warning'
                    );
                }

                LoadProducts($("#search-products-hidden").val(), $("#page-number").val(), $("#take-number").val());
            })

        }
    });
}


function LoadGalleryImages(id) {

    var postData = {
        'productId': id
    }

    $("#Gallery_Images").load("/Admin/Product/LoadGalleryImages", postData);

}

function ShowGalleryModal(productId, productTitle) {

    $("#Gallery_ProductId").val(productId);
    $("#Gallery_ProductTitle").html(productTitle);
    $("#Gallery_ImgUps").val(null);

    LoadGalleryImages(productId);

    $("#ProductGalleryModal").modal('show');
}

function AddImageToGallery() {

    var imagesData = new FormData();
    var productId = $("#Gallery_ProductId").val();

    var totalfiles = document.getElementById('Gallery_ImgUps').files.length;

    if (totalfiles > 0) {



        for (var index = 0; index < totalfiles; index++) {
            imagesData.append("images", document.getElementById('Gallery_ImgUps').files[index]);
        }

        imagesData.append("productId", productId);

        $.ajax({
            contentType: false,
            processData: false,
            url: '/Admin/Product/AddImageToGallery',
            type: 'POST',
            data: imagesData,
            dataType: 'json',
            success: function (data) {

                LoadGalleryImages(productId);
                $("#Gallery_ImgUps").val(null);

                if (data == false) {
                    swal.fire(
                        'ناموفق',
                        "ثبت تصویر با شکست مواجه شد",
                        'warning'
                    );
                } else {
                    swal.fire(
                        'موفق',
                        "ثبت تصویر با موفقیت انجام شد",
                        'success'
                    );
                }
            }
        });
    } else {
        swal.fire(
            'ناموفق',
            "ابتدا تصاویر خود را انتخاب کنید",
            'warning'
        );
    }
}

function DeleteGalleryImage(imageId) {

    swal.fire({
        title: 'حذف  تصویر',
        text: 'آیا از حذف این تصویر مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'imageId': imageId
            };

            $.post("/Admin/Product/DeleteImageFromGallery", postData, function (data) {

                if (data.data == false) {
                    swal.fire(
                        'ناموفق',
                        "عملیات حذف تصویر با شکست مواجه شد",
                        'warning'
                    );
                } else {
                    $("#ProductGalleryImage" + imageId).hide('2000');
                }
            });
        }
    });
}

function ShowSlidersModal(productId) {

    var postData = {
        "productId": productId
    };

    $.ajaxSetup({
        async: false,
        method: "get"
    });

    $("#product-sliders").load("/Admin/Product/LoadProductSliders/", postData);

    $("#SlidersModal").modal('show');
}

function ChangeProductSliders() {

    var productId = $("#ProductSlider_ProductId").val();

    var sliders = [];
    $(".sliders").each(function (i) {

        var id = $(this).attr("id");

        var sliderId = id.split("_")[1];
        var checked = $("#" + id).is(":checked");

        sliders[i] = {
            "sliderId": sliderId,
            "checked": checked
        };

    });

    var postData = {
        "productId": productId,
        "sliders": sliders
    };

    $.post("/Admin/Product/ChangeProductSliders", postData, function (data) {

        if (data.isSuccess != false) {
            $("#SlidersModal").modal('hide');
            swal.fire(
                'موفق',
                data.message,
                'success'
            ).then((confirm) => {
                ShowSlidersModal(productId);
            });
        } else {
            swal.fire(
                'ناموفق',
                data.message,
                'warning'
            );
        }
    });
}

function TakeNumberChanged(value) {

    $("#take").val(value);
    LoadProducts($("#search-products-hidden").val(), 1, value);
}

$(document).ready(LoadProducts($("#search-products-hidden").val(), $("#page-number").val(), $("#take").val()))