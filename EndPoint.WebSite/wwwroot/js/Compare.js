function AddProductToBasket(productId) {
    var postData = {
        "productId": productId,
        "count": 1
    };

    $.post("/Cart/AddToCart", postData,
        function (data) {
            if (data.isSuccess) {
                LoadBasket();
                $("#snack-bar").addClass("show");
                $("#snack-bar").empty();
                $("#snack-bar").append(data.message);

                setTimeout(function () {
                    $("#snack-bar").removeClass("show");
                }, 3000);
            }
        });
}

function RemoveFromCompare(productId) {

    var postData = {
        'productId': productId
    };

    $.post("/Compare/RemoveFromCompare", postData, function (data) {

        if (data.isSuccess) {
            location.reload();
        }
    });
}