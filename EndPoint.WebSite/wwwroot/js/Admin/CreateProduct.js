

function LoadMainImage(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#productImage").attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }


}

function LoadGalleryImages(input) {

    for (var i = 0; i < input.files.length; i++) {

        if (input.files && input.files[i]) {

            var reader = new FileReader();
            reader.onload = function (e) {

                var el = '<div id="container-galleryImages-' + e.loaded + '" class="col-md-5 col-sm-5 d-inline-block p-0">' +
                    '<figure class="effect-winston">' +
                    '<img name="gallery" id="galleryImages-' + e.loaded + '" width="250" alt="img06">' +
                    '<figcaption>' +
                    '<p><a onclick="DeleteGalleryImage(' + e.loaded + ')" class="danger p-3"><i class="fa fa-trash-o font-large-2 mr-0"></i></a></p>' +
                    '</figcaption>' +
                    '</figure>' +
                    '</div>';

                $("#galleryImages").append(el);
                $('#galleryImages-' + e.loaded).attr('src', e.target.result);
            }

            reader.readAsDataURL(input.files[i]);
        }
    }
}

function DeleteGalleryImage(id) {

    $("#container-galleryImages-" + id).remove();

}

function SeparateNum(number_input) {
    if (number_input[0] == 0) {

        return "";
    }
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

function LoadSubCategories(tagId, parentTagId) {

    var parentId = $("#" + parentTagId).val();

    if (parentTagId == "categories") {

        $("#groups").html('<option value="0">انتخاب گروه</option>');
        $("#subGroups").html('<option value="0">انتخاب زیرگروه</option>');

    } else if (parentTagId == "groups") {

        $("#subGroups").html('<option value="0">انتخاب زیرگروه</option>');
    }

    if (parentId > 0) {

        var postData = {
            "id": parentId
        };
        $("#" + tagId).load("/Admin/Product/loadsubcategories", postData);
    }


    console.log(window.editor.getData());

}

function dataURLtoFile(dataurl, filename) {

    var arr = dataurl.split(','),
        mime = arr[0].match(/:(.*?);/)[1],
        bstr = atob(arr[1]),
        n = bstr.length,
        u8arr = new Uint8Array(n);

    while (n--) {
        u8arr[n] = bstr.charCodeAt(n);
    }

    return new File([u8arr], filename, { type: mime });
}

function myfunction(e) {

    e.preventDefault();
    console.log(window.editor.getData());

    //var x = document.(".ck-content figure.image image").("src")

    var fiqures = $(".ck-content").children("figure.image");
    console.log(fiqures);
    for (var i = 0; i < fiqures.length; i++) {

        var figure = fiqures[i];

        console.log(figure);

        var images = figure.children("img");
        console.log(images);

        for (var j = 0; j < images.length; j++) {

            var image = images[j];

            console.log(images.attr("src"));
        }
    }

    //$("#myform").submit();
}

$(document).ready(function () {

    $("#myform").on("submit", function (e) {

        myfunction(e);
    })
});

$(document).ready(function () {

    ClassicEditor
        .create(document.querySelector('#Description'), {
            removePlugins: ['title'],
            toolbar: {
                items: [
                    'heading',
                    '|',
                    'bulletedList',
                    'numberedList',
                    '|',
                    'outdent',
                    'indent',
                    'alignment',
                    '|',
                    'specialCharacters',
                    'link',
                    'findAndReplace',
                    'blockQuote',
                    'insertTable',
                    '|',
                    'undo',
                    'redo',
                    '-',
                    'bold',
                    'italic',
                    'fontBackgroundColor',
                    'fontSize',
                    'fontFamily',
                    'fontColor',
                    'highlight',
                    'horizontalLine',
                    'underline',
                    '|',
                    'imageUpload',
                    'mediaEmbed'
                ],
                shouldNotGroupWhenFull: true
            },
            language: 'en',
            image: {
                toolbar: [
                    'imageTextAlternative',
                    'imageStyle:full',
                    'imageStyle:side',
                    'linkImage'
                ]
            },
            table: {
                contentToolbar: [
                    'tableColumn',
                    'tableRow',
                    'mergeTableCells',
                    'tableCellProperties',
                    'tableProperties'
                ]
            },
            licenseKey: '',
        })
        .then(editor => {
            window.editor = editor;
        })
        .catch(error => {
            console.error('Oops, something went wrong!');
            console.error(error);
        });
});



