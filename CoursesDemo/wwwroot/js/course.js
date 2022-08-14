(function ($) {

    // handle add course btn Click
    $('button[data-toggle="modal"]').on('click', function (e) {
        modelPopup(this);
    });

    function carouselSettings() {

        // at first start disable prev btn
        $('#prev').prop('disabled', true);
        $('#prev').addClass('disabled');

        // stop looping in Carousel
        $('#slidingLayout').carousel({
            interval: 0,
            wrap: false
        });

        $('#slidingLayout').on('slid.bs.carousel', '', function (event) {

            // indicators
            var nextactiveslide = $(event.relatedTarget).index();
            var $active = $(`[data-slide-to='${nextactiveslide}']`);
            $('.indicators').removeClass('active');
            $active.addClass('active');


            if ($('.carousel-inner .carousel-item:first').hasClass('active')) {
                $('#prev').prop('disabled', true);
                $('#prev').addClass('disabled');
                $('#next').prop('disabled', false);
                $('#next').removeClass('disabled');

            } else if ($('.carousel-inner .carousel-item:last').hasClass('active')) {
                $('#prev').prop('disabled', false);
                $('#prev').removeClass('disabled');
                $('#next').prop('disabled', true);
                $('#next').addClass('disabled');
            }

        });
    }

    function multiSelectSetup(selectControllerId, listControllerId, event) {

        // create unique Symbole
        var unquieSymbole = $(event).data('unique');

        // get Select value and Text
        let selectedValue = $(`#${selectControllerId}`).find(":selected").val();
        let selectedText = $(`#${selectControllerId}`).find(":selected").text();

        if (selectedValue === '0')
            return

        // append new li to Ul
        $(`#${listControllerId}`).append(
            `<li id="li-${unquieSymbole}-${selectedValue}" class="list-inline-item text-white py-2 px-3 rounded-pill" style="background-color: #63BACF;cursor:pointer;">
                                ${selectedText}
                                <span id="btn-${unquieSymbole}-${selectedValue}" class="font-weight-bolder ml-1">&radic;</span>
                            </li>`
        );

        // add Event 
        $(`#li-${unquieSymbole}-${selectedValue}`).hover(
            (event) => {
                event.target.classList.add("bg-danger");
                $(`#btn-${unquieSymbole}-${selectedValue}`).addClass("bg-danger");
                $(`#btn-${unquieSymbole}-${selectedValue}`).html(`&Chi;`);
            },
            (event) => {

                event.target.classList.remove("bg-danger");
                event.target.style.backgroundColor = '#63BACF!important';
                $(`#btn-${unquieSymbole}-${selectedValue}`).removeClass("bg-danger");
                $(`#btn-${unquieSymbole}-${selectedValue}`).html(`&radic;`);
            }
        );

        // add event on remove btn
        $(`#btn-${unquieSymbole}-${selectedValue}`).on("click", () => {
            $(`ul#${listControllerId} li[id="li-${unquieSymbole}-${selectedValue}"]`).remove();
            $(`select#${selectControllerId} option[value="${selectedValue}"]`).show();
        });

        // remove appended element from options
        let removeOption = $(`select#${selectControllerId} option[value="${selectedValue}"]`);
        removeOption.hide();

        // reset selected value
        $(`select#${selectControllerId} option[value="0"]`).prop("selected", true);

    }

    function modelSettings() {

        // Carousel Settings
        carouselSettings();

        // Adding Controls Actions
        $("#btnGainSkill").on('click', (event) => {
            multiSelectSetup("gainSkills", "selectedGainSkills", event);
        });

        $("#btnRequirdSkill").on('click', (event) => {
            multiSelectSetup("requirdSkills", "selectedRequirdSkills", event)
        });

        $("#btnModule").on('click', (event) => {
            multiSelectSetup("courseModules", "selectedModule", event)
        });

        $('#imgInp').on('change', evt => {
            const [file] = imgInp.files
            if (file) {
                $('#courseImg').attr('src', URL.createObjectURL(file));
                $('#courseImg').on('load', () => {
                    URL.revokeObjectURL(courseImg.src) // free memory
                });
            }
        });

        $(`button[data-save="modal"]`).on('click', function (event) {
            event.preventDefault();
            var form = $(this).parents('.modal').find('form');
            var actionUrl = form.attr('action');
            var dataToSend = new FormData(form.get(0));
            $.ajax({
                url: actionUrl,
                method: 'post',
                data: dataToSend,
                processData: false,
                contentType: false
            }).done(function (data) {
                var newContent = $(data);
                var isValid = newContent.find('input[name="IsValid"]').val() === 'True';
                if (!isValid) {
                    $('#modal-create-edit-course').find('.modal-content').replaceWith(data);
                }

                $('#modal-create-edit-course').find('.modal').modal('hide');
            });
        });


    }

    // open Model
    function modelPopup(reff) {

        var url = $(reff).data('url');
        var placeholderElement = $('#modal-create-edit-course');

        $.get(url).done(function (data) {

            // adding html to model
            placeholderElement.find(".modal-dialog").html(data);
            placeholderElement.find('.modal').modal("show");

            // setup Model Settings
            modelSettings();

        });
    }

}(jQuery));


//event.preventDefault();
//var form = $(this).parents('.modal').find('form');
//var actionUrl = form.attr('action');
//var dataToSend = form.serialize();

//$.post(actionUrl, dataToSend).done(function (data) {
//    console.log(data);
//    var newBody = $('.modal-body', data);
//    console.log
//    placeholderElement.find('.modal-body').replaceWith(newBody);

//    var isValid = newBody.find('[name="IsValid"]').val() == 'True';
//    if (isValid)
//        placeholderElement.find('.modal').modal('hide');
//});

{

    //$("#btnGainSkill").on('click', () => {

    //    // get Select value and Text
    //    let selectedValue = $('#gainSkills').find(":selected").val();
    //    let selectedText = $('#gainSkills').find(":selected").text();

    //    if (selectedValue === '0')
    //        return

    //    // append new li to Ul
    //    $("#selectedGainSkills").append(
    //        `<li id="g${selectedValue}" class="list-inline-item text-white py-2 px-3 rounded-pill" style="background-color: #63BACF;cursor:pointer;">
    //                    ${selectedText}
    //                    <span id="btng${selectedValue}" class="font-weight-bolder ml-1">&radic;</span>
    //                </li>`
    //    );

    //    // add Event 
    //    $(`#g${selectedValue}`).hover(
    //        (event) => {
    //            event.target.classList.add("bg-danger");
    //            $(`#btng${selectedValue}`).addClass("bg-danger");
    //            $(`#btng${selectedValue}`).html(`&Chi;`);
    //        },
    //        (event) => {

    //            event.target.classList.remove("bg-danger");
    //            event.target.style.backgroundColor = '#63BACF!important';
    //            $(`#btng${selectedValue}`).removeClass("bg-danger");
    //            $(`#btng${selectedValue}`).html(`&radic;`);
    //        }
    //    );

    //    // add event on remove btn
    //    $(`#btng${selectedValue}`).on("click", () => {
    //        $(`ul#selectedGainSkills li[id="g${selectedValue}"]`).remove();
    //        $(`select#gainSkills option[value="${selectedValue}"]`).show();
    //    });

    //    // remove appended element from options
    //    let removeOption = $(`select#gainSkills option[value="${selectedValue}"]`);
    //    removeOption.hide();

    //    // reset selected value
    //    $(`select#gainSkills option[value="0"]`).prop("selected", true);
    //});

    //$("#btnRequirdSkill").on('click', () => {

    //    // get Select value and Text
    //    let selectedValue = $('#requirdSkills').find(":selected").val();
    //    let selectedText = $('#requirdSkills').find(":selected").text();

    //    if (selectedValue === '0')
    //        return

    //    // append new li to Ul
    //    $("#selectedRequirdSkills").append(
    //        `<li id="r${selectedValue}" class="list-inline-item text-white py-2 px-3 rounded-pill" style="background-color: #63BACF;cursor:pointer;">
    //                    ${selectedText}
    //                    <span id="btnr${selectedValue}" class="font-weight-bolder ml-1">&radic;</span>
    //                </li>`
    //    );

    //    // add Event 
    //    $(`#r${selectedValue}`).hover(
    //        (event) => {
    //            event.target.classList.add("bg-danger");
    //            $(`#btnr${selectedValue}`).addClass("bg-danger");
    //            $(`#btnr${selectedValue}`).html(`&Chi;`);
    //        },
    //        (event) => {

    //            event.target.classList.remove("bg-danger");
    //            event.target.style.backgroundColor = '#63BACF!important';
    //            $(`#btnr${selectedValue}`).removeClass("bg-danger");
    //            $(`#btnr${selectedValue}`).html(`&radic;`);
    //        }
    //    );

    //    // add event on remove btn
    //    $(`#btnr${selectedValue}`).on("click", () => {
    //        $(`ul#selectedRequirdSkills li[id="r${selectedValue}"]`).remove();
    //        $(`select#requirdSkills option[value="${selectedValue}"]`).show();
    //    });

    //    // remove appended element from options
    //    let removeOption = $(`select#requirdSkills option[value="${selectedValue}"]`);
    //    removeOption.hide();

    //    // reset selected value
    //    $(`select#requirdSkills option[value="0"]`).prop("selected", true);
    //});

    //$("#btnModule").on('click', () => {

    //    // get Select value and Text
    //    let selectedValue = $('#courseModules').find(":selected").val();
    //    let selectedText = $('#courseModules').find(":selected").text();

    //    if (selectedValue === '0')
    //        return

    //    // append new li to Ul
    //    $("#selectedModule").append(
    //        ` <li id="m${selectedValue}" class="list-inline-item text-white py-2 px-3 rounded-pill" style="background-color: #63BACF;cursor:pointer;">
    //                    ${selectedText}
    //                    <span id="btnm${selectedValue}" class="font-weight-bolder ml-1">&radic;</span>
    //                  </li>`
    //    );

    //    // add Event 
    //    $(`#m${selectedValue}`).hover(
    //        (event) => {
    //            event.target.classList.add("bg-danger");
    //            $(`#btnm${selectedValue}`).addClass("bg-danger");
    //            $(`#btnm${selectedValue}`).html(`&Chi;`);
    //        },
    //        (event) => {

    //            event.target.classList.remove("bg-danger");
    //            event.target.style.backgroundColor = '#63BACF!important';
    //            $(`#btnm${selectedValue}`).removeClass("bg-danger");
    //            $(`#btnm${selectedValue}`).html(`&radic;`);
    //        }
    //    );

    //    // add event on remove btn
    //    $(`#btnm${selectedValue}`).on("click", () => {
    //        $(`ul#selectedModule li[id="m${selectedValue}"]`).remove();
    //        $(`select#courseModules option[value="${selectedValue}"]`).show();
    //    });

    //    // remove appended element from options
    //    let removeOption = $(`select#courseModules option[value="${selectedValue}"]`);
    //    removeOption.hide();

    //    // reset selected value
    //    $(`select#courseModules option[value="0"]`).prop("selected", true);
    //});
}