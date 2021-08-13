
function LoadUsers() {

    var searchKey = $("#search-users-input").val();
    var pageNumber = $("#page-number").val();

    var postData = {
        'searchKey': searchKey,
        'page': pageNumber
    };

    $("#dt-UsersData").load("/Admin/Users/LoadUsers", postData);
}

function ChangeStatus(userId, username, isActive) {
    var _text = "";
    if (isActive == true) {
        _text = "غیرفعال";
    } else {
        _text = "فعال";
    }

    swal.fire({
        title: 'تغییر وضعیت حساب کاربر',
        text: 'آیا از ' + _text + ' کردن" ' + username + ' "' + 'مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'userId': userId
            };
            $.post("/Admin/Users/ChangeStatus", postData,
                function (data) {
                    if (data) {
                        swal.fire(
                            'موفق!',
                            'کاربر با موفقیت فعال شد',
                            'success'
                        ).then(function (isConfirm) {
                            LoadUsers();
                        });
                    }
                    else {

                        swal.fire(
                            'موفق!',
                            'کاربر با موفقیت غیرفعال شد',
                            'success'
                        ).then(function (isConfirm) {
                            LoadUsers();
                        });
                    }
                });
        }
    });
}

function DeleteUser(username, userId) {
    swal.fire({
        title: 'حذف کاربر',
        text: 'آیا از حذف' + '" ' + username + ' "' + 'مطمئن هستید؟',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله، مطمئن هستم',
        cancelButtonText: 'خیر'
    }).then((result) => {
        if (result.value) {
            var postData = {
                'userId': userId
            };

            $.post("/Admin/Users/Delete", postData, function () {
                swal.fire(
                    'موفق!',
                    'کاربر با موفقیت حذف شد',
                    'success'
                ).then(function (isConfirm) {
                    LoadUsers();
                });
            });
        }
    });
}

$(document).ready(LoadUsers());