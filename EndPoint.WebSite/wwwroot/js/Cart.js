
function CalculateTotalAmount() {
    var totalPrices = $(".product-totalPrice");
    var totalAmount = 0;

    for (var i = 0; i < totalPrices.length; i++) {
        var text = totalPrices[i].innerText.replace("تومان", "").replace(",", "").replace(",", "").replace(",", "");
        var x = text.split(",");
        var price = "";
        for (var j = 0; j < x.length; j++) {
            price += x[j];
        }
        totalAmount += Number(price);
    }

    $("input.total-amount").val(totalAmount);
    $("span.total-amount").text(SeparateNum(totalAmount) + " تومان");
}

function UpdateProductCount(productId) {

    var count = $("#product-" + productId + "-count").val();
    var max = $("#product-" + productId + "-count").attr("max");
    var min = $("#product-" + productId + "-count").attr("min");
    if (count <= max || count >= min) {
        var text = $("#product-" + productId + "-price").text();
        text = text.replace("تومان", "");
        text = text.replace(",", "");
        text = text.replace(",", "");
        text = text.replace(",", "");
        text = text.replace(",", "");
        text = text.replace(",", "");
        text = text.trim();
        var price = Number(text);
        var totalPrice = price * count;
        $("#product-" + productId + "-totalPrice").text(SeparateNum(totalPrice) + " تومان");

        CalculateTotalAmount();
        LoadBasket();
    }

}

function SeparateNum(number_input) {
    number_input += '';
    number_input = number_input.replace(',', ''); number_input = number_input.replace(',', ''); number_input = number_input.replace(',', '');
    number_input = number_input.replace(',', ''); number_input = number_input.replace(',', ''); number_input = number_input.replace(',', '');
    x = number_input.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1))
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    return x1 + x2;
}

function RemoveProduct(productId) {
    var postData = {
        "productId": productId
    };

    $.post("/Cart/RemoveFromCart", postData,
        function (data) {
            if (data.isSuccess) {

                location.reload();
            }
        });
}

function SaveAndCheckOut() {

    var rows = $(".productId");
    var Products = new Array(rows.length);

    for (var i = 0; i < rows.length; i++) {

        var productId = Number(rows[i].value);
        var productCount = $("#product-" + productId + "-count").val();

        var item = {
            "productId": productId,
            "count": productCount
        };

        Products[i] = item;
    }

    var postData = {
        "cartItems": Products,
    };

    $.post("/Cart/SaveCartChanges", postData,
        function (data) {
            if (!data.isSuccess) {
                swal.fire(
                    'خطا!',
                    data.message,
                    'warning'
                );
            } else {
                window.location.href = data.message;
            }
        });

}

function quantitySelector() {
    $('<div class="quantity-nav"><div class="quantity-button quantity-up">+</div><div class="quantity-button quantity-down">-</div></div>').insertAfter('.quantity input');
    $('.quantity').each(function () {
        var spinner = $(this),
            input = spinner.find('input[type="number"]'),
            btnUp = spinner.find('.quantity-up'),
            btnDown = spinner.find('.quantity-down'),
            min = input.attr('min'),
            max = input.attr('max');

        btnUp.click(function () {
            var oldValue = parseFloat(input.val());
            if (oldValue >= max) {
                var newVal = oldValue;
            } else {
                var newVal = oldValue + 1;
            }
            spinner.find("input").val(newVal);
            spinner.find("input").trigger("change");
        });

        btnDown.click(function () {
            var oldValue = parseFloat(input.val());
            if (oldValue <= min) {
                var newVal = oldValue;
            } else {
                var newVal = oldValue - 1;
            }
            spinner.find("input").val(newVal);
            spinner.find("input").trigger("change");
        });

        console.log("each");
    });

    console.log("outEach");
}

$(document).ready(quantitySelector());