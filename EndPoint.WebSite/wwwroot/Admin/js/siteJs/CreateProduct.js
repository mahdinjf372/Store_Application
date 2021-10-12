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

    if (number_input[0] == 0 && number_input.length > 1) {
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
}

function Tagging(event) {
    var reg = /^([a-z0-9A-Z\u0600-\u06FF\s _-]+)$/;
    if (!reg.test(event.data)) {
        alert("فقط حروف و اعداد و -_");
        var old = $("#tag-input").val();
        old = old.substr(0, old.length - 1);
        $("#tag-input").val(old);
        return "";
    } else {
        var text = $("#tag-input").val();
        if (reg.test(text)) {

            text = text.trim();
            var tags = text.split("-");
            $("#tag-divs").empty();
            for (var i = 0; i < tags.length; i++) {

                var tag = tags[i];
                tag = tag.trim();
                if (tag == "" || tag == " ")
                    break;

                while (tag.includes(" ")) {
                    tag = tag.replace(" ", "_");
                }

                var elm = "<div class=\"tag d-inline-block text-white font-small-3\">" +
                    "<span>#</span> " + tag + "</div>";

                $("#tag-divs").append(elm);
            }
        }
    }

}

$(document).ready(function () {

    ClassicEditor
        .create(document.querySelector('#Description'), {
            removePlugins: ['Title'],
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
            heading: {
                options: [
                    { model: 'paragraph', title: 'Paragraph', class: '' },
                    { model: 'heading2', view: 'h2', title: 'Heading 1', class: 'params-headline' },
                    { model: 'heading3', view: 'h3', title: 'Heading 2', class: 'content-expert-title' },
                ]
            },
            language: 'en',
            image: {
                toolbar: [
                    'imageTextAlternative',
                    'imageStyle:full',
                    'imageStyle:side',
                    'linkImage'
                ],
                upload: {
                    types: ['png', 'jpeg'],
                }
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