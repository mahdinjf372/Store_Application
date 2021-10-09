
function RemoveFromFavorite(productId) {

    var postData = {
        "productId": productId
    };

    $.post("/UserPanel/Favorite/RemoveFromFavorite", postData, function (data) {

        if (data.isSuccess) {

            $(".product-" + productId).hide("slow");
        }
    });
}