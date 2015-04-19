var nameCounter = 1;
var nightCounter = 0;
$(document).ready(function () {

    /*----- add boxes for nights -----*/
    $("#addNightButton").click(function () {
        if (nameCounter == 29) {
            alert("Možete prenociti samo 30 dana")
        }
        else {
            var nameDiv = "#nights" + nightCounter;
            $(nameDiv).show();
            nightCounter++;
        }
    });
    $("#removeNightButton").click(function () {
        if (nightCounter == 0) {
            alert("Nema više noćenja koje možete izbrisati");
        }
        else {
            nightCounter--;
            var nameDiv = "#nights" + nightCounter;
            $(nameDiv).hide();
        }

    });
    /*----- add textboxes for names -----*/
    $("#addPersonButton").click(function () {
        if (nameCounter == 10) {
            alert("Možete tražiti putne naloge najviše za 10 ljudi")
        }
        else {
            var nameDiv = "#name-field" + nameCounter;
            $(nameDiv).show();
            nameCounter++;
        }
    });
    $("#removePersonButton").click(function () {
        if (nameCounter == 1) {
            alert("Mora postojati barem jedan putnik");
        }
        else {
            nameCounter--;
            var nameDiv = "#name-field" + nameCounter;
            $(nameDiv).hide();
        }

    });

    /*----- datepickers -----*/
    $("#from").datepicker({
        dateFormat: "dd/mm/yy",
        onClose: function (selectedDate) {
            $("#to").datepicker("option", "minDate", selectedDate);
            $("#exit").datepicker("option", "minDate", selectedDate);
            $("#entry").datepicker("option", "minDate", selectedDate);
        }
    });
    $("#to").datepicker({
        dateFormat: "dd/mm/yy",
        onClose: function (selectedDate) {
            $("#from").datepicker("option", "maxDate", selectedDate);
            $("#entry").datepicker("option", "maxDate", selectedDate);
            $("#exit").datepicker("option", "maxDate", selectedDate);
        }
    });

    $("#entry").datepicker({
        dateFormat: "dd/mm/yy",
        onClose: function (selectedDate) {
            $("#exit").datepicker("option", "minDate", selectedDate);
        }
    });

    $("#exit").datepicker({
        dateFormat: "dd/mm/yy",
        onClose: function (selectedDate) {
            $("#entry").datepicker("option", "maxDate", selectedDate);
        }
    });

    $(document).on("focus", ".Date", function () {
        $(".Date").datepicker({
            dateFormat: "dd/mm/yy",
            minDate: $.datepicker.parseDate("dd/mm/yy", $("#entry").val()),
            maxDate: $.datepicker.parseDate("dd/mm/yy", $("#exit").val())
        });
    });

    $(".Date").keydown(function (event) {
        event.preventDefault();
    });
    $("#from").keydown(function (event) {
        event.preventDefault();
    });
    $("#to").keydown(function (event) {
        event.preventDefault();
    });
    /*----- show if needed -----*/
    $("#AccommodationCheckbox").change(function () {
        if (this.checked) {
            $(".accommodation-label").show();
            $(".accommodation-field").show();
            $(".accommodation-button").show();
        }
        else {
            $(".accommodation-label").hide();
            $(".accommodation-field").hide();
            $(".accommodation-button").hide();
        }
    });

    $("#VehicleType").change(function () {
        if ($("#VehicleType option:selected").text() == "Automobil") {
            $(".vehicle-label").show();
            $(".vehicle-field").show();
        }
        else {
            $(".vehicle-label").hide();
            $(".vehicle-field").hide();
        }
    });
});

