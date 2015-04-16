$(document).ready(function () {

    $("#from").datepicker({
        dateFormat: 'dd/mm/yy',
        defaultDate: "+1w",
        onClose: function (selectedDate) {
            $("#to").datepicker("option", "minDate", selectedDate);
        }
    });
    $("#to").datepicker({
        dateFormat: 'dd/mm/yy',
        defaultDate: "+1w",
        onClose: function (selectedDate) {
            $("#from").datepicker("option", "maxDate", selectedDate);
        }
    });

    $(".Date").datepicker({
        dateFormat: 'dd/mm/yy'
    });

    $('#AccommodationCheckbox').change(function () {
        if (this.checked) {
            $('.accomodation-label').show();
            $('.accomodation-field').show();
        }
        else {
            $('.accomodation-label').hide();
            $('.accomodation-field').hide();
        }
    });


});

