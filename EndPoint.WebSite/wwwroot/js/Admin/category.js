

function LoadCategories() {
    $("#dt-CategoriesData").load("/Admin/Category/LoadCategories");
}

function LoadSubCategories(dropDownTagId, categoryId) {

    if (categoryId != 0) {
        var postData = {
            'parentCategoryId': categoryId
        };

        $("#" + dropDownTagId).load("/Admin/Category/LoadSubCategories", postData);
    }
}

function LoadSubGroups(dropDownTagId, subCategoryId = 0) {

    subCategoryId = $("#EditSubCategories_SubCategories").val();

    $("#EditSubCategories_SubCategoryId").val(subCategoryId);

    if (subCategoryId != 0) {
        var postData = {
            'parentCategoryId': subCategoryId
        };

        $("#" + dropDownTagId).load("/Admin/Category/LoadSubCategories", postData)

    } else {
        $("#EditSubCategories_SubGroups").empty();
        var option = "<option selected=\"selected\" value=\"0\">لطفا گروه را انتخاب کنید</option>";
        $("#EditSubCategories_SubGroups").append(option);
    }
}


function ShowEditCategoryModal(categoryTitle, categoryId) {
    $('#Edit_CategoryId').val(categoryId);
    $('#Edit_CategoryName').val(categoryTitle);
    $('#EditCategoryModal').modal('show');
}

function EditCategory() {
    var CategoryId = $('#Edit_CategoryId').val();
    var CategoryName = $('#Edit_CategoryName').val();


    var postData = {
        'Id': CategoryId,
        'Title': CategoryName
    };

    $.post("/Admin/Category/EditCategory", postData, function (data) {

        if (data.isSuccess) {
            swal.fire(
                'موفق!',
                data.message,
                'success'
            ).then(function (isConfirm) {
                LoadCategories();
                $('#EditCategoryModal').modal('hide');
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


function ShowEditSubCategoriesModal(categoryTitle, categoryId) {
    $('#EditSubCategories_CategoryId').val(categoryId);
    $('#EditSubCategories_CategoryName').html(categoryTitle);

    LoadSubCategories("EditSubCategories_SubCategories", categoryId);

    var option = "<option selected=\"selected\" value=\"0\">لطفا گروه را انتخاب کنید</option>";
    $("#EditSubCategories_SubGroups").html(option);

    $('#EditSubCategoriesModal').modal('show');
}


function ShowCreateCategoryModal() {

    $('#CreateCategoryModal').modal('show');
}

function CreateCategory() {

    var CategoryName = $("#Create_CategoryName").val();

    var postData = {
        'Title': CategoryName
    };

    $.post("/Admin/Category/CreateCategory", postData, function (data) {

        if (data.isSuccess) {
            swal.fire(
                'موفق!',
                data.message,
                'success'
            ).then(function (isConfirm) {
                LoadCategories();
                $("#Create_CategoryName").val(null);
                $('#CreateCategoryModal').modal('hide');
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


function ShowAddSubCategoryModal(parentCategoryId) {

    $('#Create_parentCategoryId').val(parentCategoryId);
    $('#AddSubCategoryModal').modal('show');
}

function AddSubCategory() {

    var categoryId = $("#EditSubCategories_CategoryId").val();
    var parentCategoryId = $("#Create_parentCategoryId").val();
    var subCategotyTitle = $("#Create_SubCategoryName").val();

    var postData = {
        'parentCategoryId': parentCategoryId,
        'Title': subCategotyTitle
    };

    $.post("/Admin/Category/AddSubCategory", postData, function (data) {

        if (data.isSuccess) {
            swal.fire(
                'موفق!',
                data.message,
                'success'
            ).then(function (isConfirm) {

                $("#Create_SubCategoryName").val(null);
                $("#Create_parentCategoryId").val(null);
                $('#AddSubCategoryModal').modal('hide');

                LoadSubCategories('EditSubCategories_SubCategories', categoryId);

                $("#EditSubCategories_SubGroups").empty();
                var option = "<option selected=\"selected\" value=\"0\">لطفا گروه را انتخاب کنید</option>";
                $("#EditSubCategories_SubGroups").append(option);

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


function RemoveCategory(categoryId, categoryName, isSubCategory) {

    if (categoryId != 0) {

        swal.fire({
            title: 'حذف گروه',
            text: 'اخطار: با حذف هر دسته بندی تمام زیرگروه های ان نیز حذف خواهد شد!.... ' + 'آیا از حذف گروه ' + '" ' + categoryName + ' "' + ' مطمئن هستید؟',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'بله، مطمئن هستم',
            cancelButtonText: 'خیر'
        }).then((result) => {
            if (result.value) {
                var postData = {
                    'categoryId': categoryId
                };

                $.post("/Admin/Category/RemoveCategory", postData, function (data) {

                    if (data == true) {
                        swal.fire(
                            'موفق!',
                            'success'
                        ).then(function (isConfirm) {

                            if (isSubCategory) {

                                var catId = $("#EditSubCategories_CategoryId").val();
                                LoadSubCategories("EditSubCategories_SubCategories", catId);
                                console.log(catId);
                                $("#EditSubCategories_SubGroups").empty();
                                var option = "<option selected=\"selected\" value=\"0\">لطفا گروه را انتخاب کنید</option>";
                                $("#EditSubCategories_SubGroups").append(option);
                            } else {

                                LoadCategories();
                            }

                        });

                    } else {
                        swal.fire(
                            'ناموفق!',
                            'error'
                        );
                    }
                });
            }
        });
    }
}


$(document).ready(LoadCategories());