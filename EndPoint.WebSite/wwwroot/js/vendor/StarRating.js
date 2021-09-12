$(function () {

    $(document).on({
        mouseover: function (event) {
            $(this).find('.far').addClass('rating-star-over');
            $(this).prevAll().find('.far').addClass('rating-star-over');
        },
        mouseleave: function (event) {
            $(this).find('.far').removeClass('rating-star-over');
            $(this).prevAll().find('.far').removeClass('rating-star-over');
        }
    }, '.rating-rate');


    $(document).on('click', '.rating-rate', function () {
        if (!$(this).find('.star').hasClass('rate-active')) {
            $(this).siblings().find('.star').addClass('far').removeClass('fas rate-active');
            $(this).find('.star').addClass('rate-active fas').removeClass('far rating-star-over');
            $(this).prevAll().find('.star').addClass('fas').removeClass('far rating-star-over');
        } else {
            console.log('has');
        }
    });

});