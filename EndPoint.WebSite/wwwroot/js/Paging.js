
function TakeNumberChanged(value) {

    var take = value;
    var sortBy = $("#sortBy").val();
    var key = $("#searchKey").val();

    window.location.href = "/Search?searchTitle=" + key + "&sortBy=" + sortBy + "&pageId=" + 1 + "&take=" + take;
}