(function ($) {
    function Index() {
        var $this = this;
        function initialize() {

            $(".popup").on('click', function (e) {
                modelPopup(this);
            });



            function modelPopup(reff) {
                var url = $(reff).data('url');

                $.get(url).done(function (data) {
                    $('#modal-create-edit-course').find(".modal-dialog").html(data);
                    $('#modal-create-edit-course > .modal', data).modal("show");

                    $('#slidingLayout').carousel({
                        interval: 0,
                        wrap: false
                    })

                    $('#prev').prop('disabled', true);
                    $('#prev').addClass('disabled');

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

                    $("#btnGainSkill").on('click', () => {

                        // get Select value and Text
                        let selectedValue = $('#gainSkills').find(":selected").val();
                        let selectedText = $('#gainSkills').find(":selected").text();

                        if (selectedValue === '0')
                            return

                        // append new li to Ul
                        $("#selectedGainSkills").append(
                            `<li id="g${selectedValue}" class="list-inline-item text-white py-2 px-3 rounded-pill" style="background-color: #63BACF;cursor:pointer;">
                                ${selectedText}
                                <span id="btng${selectedValue}" class="font-weight-bolder ml-1">&radic;</span>
                            </li>`
                        );

                        // add Event 
                        $(`#g${selectedValue}`).hover(
                            (event) => {
                                event.target.classList.add("bg-danger");
                                $(`#btng${selectedValue}`).addClass("bg-danger");
                                $(`#btng${selectedValue}`).html(`&Chi;`);
                            },
                            (event) => {

                                event.target.classList.remove("bg-danger");
                                event.target.style.backgroundColor = '#63BACF!important';
                                $(`#btng${selectedValue}`).removeClass("bg-danger");
                                $(`#btng${selectedValue}`).html(`&radic;`);
                            }
                        );

                        // add event on remove btn
                        $(`#btng${selectedValue}`).on("click", () => {
                            $(`ul#selectedGainSkills li[id="g${selectedValue}"]`).remove();
                            $(`select#gainSkills option[value="${selectedValue}"]`).show();
                        });

                        // remove appended element from options
                        let removeOption = $(`select#gainSkills option[value="${selectedValue}"]`);
                        removeOption.hide();

                        // reset selected value
                        $(`select#gainSkills option[value="0"]`).prop("selected", true);
                    });

                    $("#btnRequirdSkill").on('click', () => {

                        // get Select value and Text
                        let selectedValue = $('#requirdSkills').find(":selected").val();
                        let selectedText = $('#requirdSkills').find(":selected").text();

                        if (selectedValue === '0')
                            return

                        // append new li to Ul
                        $("#selectedRequirdSkills").append(
                            `<li id="r${selectedValue}" class="list-inline-item text-white py-2 px-3 rounded-pill" style="background-color: #63BACF;cursor:pointer;">
                                ${selectedText}
                                <span id="btnr${selectedValue}" class="font-weight-bolder ml-1">&radic;</span>
                            </li>`
                        );

                        // add Event 
                        $(`#r${selectedValue}`).hover(
                            (event) => {
                                event.target.classList.add("bg-danger");
                                $(`#btnr${selectedValue}`).addClass("bg-danger");
                                $(`#btnr${selectedValue}`).html(`&Chi;`);
                            },
                            (event) => {

                                event.target.classList.remove("bg-danger");
                                event.target.style.backgroundColor = '#63BACF!important';
                                $(`#btnr${selectedValue}`).removeClass("bg-danger");
                                $(`#btnr${selectedValue}`).html(`&radic;`);
                            }
                        );

                        // add event on remove btn
                        $(`#btnr${selectedValue}`).on("click", () => {
                            $(`ul#selectedRequirdSkills li[id="r${selectedValue}"]`).remove();
                            $(`select#requirdSkills option[value="${selectedValue}"]`).show();
                        });

                        // remove appended element from options
                        let removeOption = $(`select#requirdSkills option[value="${selectedValue}"]`);
                        removeOption.hide();

                        // reset selected value
                        $(`select#requirdSkills option[value="0"]`).prop("selected", true);
                    });

                    $("#btnModule").on('click', () => {

                        // get Select value and Text
                        let selectedValue = $('#courseModules').find(":selected").val();
                        let selectedText = $('#courseModules').find(":selected").text();

                        if (selectedValue === '0')
                            return

                        // append new li to Ul
                        $("#selectedModule").append(
                            ` <li id="m${selectedValue}" class="list-inline-item text-white py-2 px-3 rounded-pill" style="background-color: #63BACF;cursor:pointer;">
                                ${selectedText}
                                <span id="btnm${selectedValue}" class="font-weight-bolder ml-1">&radic;</span>
                              </li>`
                        );

                        // add Event 
                        $(`#m${selectedValue}`).hover(
                            (event) => {
                                event.target.classList.add("bg-danger");
                                $(`#btnm${selectedValue}`).addClass("bg-danger");
                                $(`#btnm${selectedValue}`).html(`&Chi;`);
                            },
                            (event) => {

                                event.target.classList.remove("bg-danger");
                                event.target.style.backgroundColor = '#63BACF!important';
                                $(`#btnm${selectedValue}`).removeClass("bg-danger");
                                $(`#btnm${selectedValue}`).html(`&radic;`);
                            }
                        );

                        // add event on remove btn
                        $(`#btnm${selectedValue}`).on("click", () => {
                            $(`ul#selectedModule li[id="m${selectedValue}"]`).remove();
                            $(`select#courseModules option[value="${selectedValue}"]`).show();
                        });

                        // remove appended element from options
                        let removeOption = $(`select#courseModules option[value="${selectedValue}"]`);
                        removeOption.hide();

                        // reset selected value
                        $(`select#courseModules option[value="0"]`).prop("selected", true);
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
                });

            }
        }

        $this.init = function () {
            initialize();
        };
    }

    $(function () {
        var self = new Index();
        self.init();
    });

}(jQuery));