function LoadFeatures(searchKey = "", pageNumber = 1) {

    postData = {
        "searchKey": searchKey,
        "page": pageNumber
    };

    $("#dt-FeaturesData").load("/Admin/Feature/LoadFeatures", postData);
}

function ShowCreateFeatureModal() {

    $("#Create_FeatureName").val(null);
    $('#CreateFeatureModal').modal('show');
}

function CreateFeature() {

    var featureName = $("#Create_FeatureName").val();

    var postData = {
        'featureName': featureName
    };

    $.post("/Admin/Feature/CreateFeature", postData, function (data) {

        if (data.isSuccess) {
            swal.fire(
                'موفق!',
                data.message,
                'success'
            ).then(function (isConfirm) {
                LoadFeatures();
                $("#Create_FeatureName").val(null);

                $('#CreateFeatureModal').modal('hide');
            });
        } else {
            swal.fire(
                'ناموفق!',
                data.message,
                'error'
            );
        }
    })
}

function DeleteFeature(featureTitle, featureId) {

    swal.fire({
        title: 'حذف  ویژگی',
        text: 'آیا از حذف' + '" ' + featureTitle + ' "' + 'مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'featureId': featureId
            };

            $.post("/Admin/Feature/DeleteFeature", postData, function (data) {

                if (data.isSuccess) {
                    swal.fire(
                        'موفق!',
                        data.message,
                        'success'
                    ).then(function (isConfirm) {
                        LoadFeatures();
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
    });
}

function ShowEditFeatureNameModal(featureTitle, featureId) {
    $('#Edit_FeatureId').val(featureId);
    $('#Edit_FeatureName').val(featureTitle);
    $('#EditFeatureNameModal').modal('show');
}

function EditFeatureName() {

    var featureId = $('#Edit_FeatureId').val();
    var featureName = $('#Edit_FeatureName').val();

    var postData = {
        'featureId': featureId,
        'featureName': featureName
    };

    $.post("/Admin/Feature/EditFeatureName", postData, function (data) {

        if (data.isSuccess) {
            swal.fire(
                'موفق!',
                data.message,
                'success'
            ).then(function (isConfirm) {

                LoadFeatures();
                $('#Edit_FeatureId').val(null);
                $('#Edit_FeatureName').val(null);
                $('#EditFeatureNameModal').modal('hide');

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

$(document).ready(LoadFeatures());