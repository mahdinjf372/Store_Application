
function LoadAds(pageNumber = 1, takeNumber = 10) {

    var postData = {

        'page': pageNumber,
        'take': takeNumber
    };

    $("#dt-Ads").load("/Admin/Advertising/LoadAdvertisings", postData);
}

function ShowCreateModal() {
    $("#Create_Places").val(0);
    $("#Create_title").val(null);
    $("#Create_linkTo").val(null);
    $("#Create_StartDate").val(null);
    $("#Create_EndDate").val(null);
    $("#Create_Description").val(null);
    $("#Create_Content").val(null);
    $("#Create_uploaded_img").attr('src', null);

    $("#CreateModal").modal('show');
}

function Create() {

    var place = $("#Create_Places").val();
    var title = $("#Create_title").val();
    var linkTo = $("#Create_linkTo").val();
    var startDate = $("#Create_StartDate").val();
    var endDate = $("#Create_EndDate").val();
    var description = $("#Create_Description").val();
    var image = document.getElementById("Create_Content").files[0];

    var postData = new FormData();
    postData.append("title", title);
    postData.append("linkTo", linkTo);
    postData.append("imageName", "default.jpg");
    postData.append("startDate", startDate);
    postData.append("endDate", endDate);
    postData.append("description", description);
    postData.append("place", place);
    postData.append("image", image);

    $.ajax({
        contentType: false,
        processData: false,
        url: '/Admin/Advertising/Create',
        type: 'POST',
        data: postData,
        dataType: 'json',
        success: function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'seccess'
                ).then(function (isConfirm) {
                    LoadAds(1, $("#take").val());

                    $("#CreateModal").modal('hide');
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

function ShowEditModal(adsId, title, imageName, startDate, endDate, description, place, linkTo) {

    $("#Edit_id").val(adsId);
    $("#Edit_places").val(place);
    $("#Edit_title").val(title);
    $("#Edit_linkTo").val(linkTo);
    $("#Edit_startDate").val(startDate);
    $("#Edit_endDate").val(endDate);
    $("#Edit_description").val(description);
    $("#Edit_Content").val(null);
    $("#Edit_uploaded_img").attr('src', "/images/adplacement/" + imageName);
    $("#Edit_imageName").val(imageName);
    $("#EditModal").modal('show');
}

function Edit() {

    var id = $("#Edit_id").val();
    var place = $("#Edit_places").val();
    var title = $("#Edit_title").val();
    var linkTo = $("#Edit_linkTo").val();
    var startDate = $("#Edit_startDate").val();
    var endDate = $("#Edit_endDate").val();
    var description = $("#Edit_description").val();
    var imageName = $("#Edit_imageName").val();
    var image = document.getElementById("Edit_Content").files[0];

    var postData = new FormData();
    postData.append("id", id);
    postData.append("title", title);
    postData.append("linkTo", linkTo);
    postData.append("imageName", imageName);
    postData.append("startDate", startDate);
    postData.append("endDate", endDate);
    postData.append("description", description);
    postData.append("place", place);
    postData.append("image", image);
    $.ajax({
        contentType: false,
        processData: false,
        url: '/Admin/Advertising/Edit',
        type: 'POST',
        data: postData,
        dataType: 'json',
        success: function (data) {
            if (data.isSuccess == true) {
                swal.fire(
                    'موفق!',
                    data.message,
                    'success'
                ).then(function (isConfirm) {
                    LoadAds($("#page-number").val(), $("#take").val());

                    $("#EditModal").modal('hide');
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

function Delete(id, title) {
    swal.fire({
        title: 'حذف کاربر',
        text: 'آیا از حذف بنر با تیتر' + '" ' + title + ' "' + 'مطمئن هستید؟',
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

            $.post("/Admin/Advertising/Delete", postData, function (data) {
                if (data.isSuccess == true) {
                    swal.fire(
                        'موفق!',
                        data.message,
                        'success'
                    ).then(function (isConfirm) {
                        LoadAds($("#page-number").val(), $("#take").val());

                    });
                } else {
                    swal.fire(
                        'خطا!',
                        data.message,
                        'warning'
                    ).then(function (isConfirm) {
                        LoadAds($("#page-number").val(), $("#take").val());

                    });
                }
            });
        }
    });
}


function TakeNumberChanged(value) {

    $("#take").val(value);
    LoadAds(1, value);
}


$(document).ready(LoadAds($("#page-number").val(), $("#take").val()));