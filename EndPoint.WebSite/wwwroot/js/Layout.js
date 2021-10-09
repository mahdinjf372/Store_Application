
function LoadBasket() {
    $("#cart-basket").load("/Cart/LoadCart");
}



function RemoveProductToBasket(productId) {
    var postData = {
        "productId": productId,
    };

    $.post("/Cart/RemoveFromCart", postData,
        function (data) {
            if (data.isSuccess == true) {
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

$(document).ready(LoadBasket());