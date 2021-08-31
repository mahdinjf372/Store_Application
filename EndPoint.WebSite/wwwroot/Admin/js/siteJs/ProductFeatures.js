
function LoadProductFeatures(searchKey = "", pageNumber = 1) {

    var productId = $("#productId").val();

    var postData = {
        'productId': productId,
        'page': pageNumber,
        'searchKey': searchKey
    };

    $("#dt-ProductFeaturesData").load("/Admin/ProductFeatures/LoadProductFeatures", postData);

}

function ShowAddProductFeatureModal() {

    LoadFeatures();

    $('#CreateModal').modal('show');
}

function Create(e) {

    e.preventDefault();

    var ProductFeatureValue = $("#Create_ProductFeatureValue").val();
    var FeatureId = $("#Create_Features").val();
    var ProductId = $("#productId").val();

    var postData = {
        'value': ProductFeatureValue,
        'featureId': FeatureId,
        'productId': ProductId
    };

    $.post('/Admin/ProductFeatures/Create', postData, function (data) {
        if (data.isSuccess == true) {
            swal.fire(
                'موفق!',
                data.message,
                'success'
            ).then(function (isConfirm) {
                LoadProductFeatures();
                $("#Create_ProductFeatureValue").val(null);

                $('#CreateModal').modal('hide');
            });
        } else {
            swal.fire(
                'ناموفق!',
                data.message,
                'error'
            );
        }
    });
}

function LoadFeatures() {

    $("#Create_Features").load("/Admin/ProductFeatures/LoadFeatures");
}

function ChangeBoldStatus(pf_Id, featureTitle, featureValue, isBold) {

    var _text = "";
    if (isBold == true) {
        _text = "غیرفعال";
    } else {
        _text = "فعال";
    }

    swal.fire({
        title: 'تغییر وضعیت برجستگی ویژگی',
        text: 'آیا از ' + _text + ' کردن برجستگی ویژگی" ' + featureTitle + ' : ' + featureValue + '" مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'productFeatureId': pf_Id
            };

            $.post("/Admin/ProductFeatures/ChangeBoldStatus", postData, function (data) {

                if (data != false) {
                    LoadProductFeatures();
                    swal.fire(
                        data.isSuccess ? 'موفق!' : 'ناموفق!',
                        data.message,
                        data.isSuccess ? 'success' : 'warning'
                    );
                } else {
                    swal.fire(
                        'ناموفق!',
                        'ویژگی مورد نظر یافت نشد',
                        'warning'
                    );
                }
            })

        }
    });
}

function Delete(featureTitle, productFeatureValue, pf_Id) {
    swal.fire({
        title: 'حذف  ویژگی محصول',
        text: 'آیا از حذف ویژگی "' + featureTitle + '" ' + 'با مقدار' + ' "' + productFeatureValue + '" ' + 'مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'productFeatureId': pf_Id
            };

            $.post("/Admin/ProductFeatures/Delete", postData, function (data) {

                if (data != false) {
                    LoadProductFeatures();
                    swal.fire(
                        data.isSuccess ? 'موفق!' : 'ناموفق!',
                        data.message,
                        data.isSuccess ? 'success' : 'warning'
                    );
                } else {
                    swal.fire(
                        'ناموفق!',
                        'ویژگی مورد نظر یافت نشد',
                        'warning'
                    );
                }
            })
        }
    });
}

function ShowEditModal(featureValue, pf_Id) {
    $('#Edit_ProductFeatureId').val(pf_Id);
    $('#Edit_Value').val(featureValue);
    $('#EditModal').modal('show');
}

function Edit(e) {

    e.preventDefault();

    var ProductFeatureId = $('#Edit_ProductFeatureId').val();
    var ProductFeatureValue = $('#Edit_Value').val();

    var postData = {
        'pfId': ProductFeatureId,
        'value': ProductFeatureValue
    };


    $.post("/Admin/ProductFeatures/Edit", postData, function (data) {

        if (data.isSuccess == true) {
            swal.fire(
                'موفق!',
                data.message,
                'success'
            ).then(function (isConfirm) {
                LoadProductFeatures();
                $('#Edit_ProductFeatureId').val(null);
                $('#Edit_Value').val(null);
                $('#EditModal').modal('hide');
            });
        } else {
            swal.fire(
                'ناموفق!',
                data.message,
                'error'
            );
        }
    });

}

$(document).ready(LoadProductFeatures());

$(function () {

    $("#Create_Features").change(function () {
        var featureId = $("#Create_Features").val();
        if (featureId != 0) {
            $("#Create_ProductFeatureValue").prop('disabled', false);
        } else {
            $("#Create_ProductFeatureValue").prop('disabled', true);
        }
    });
});