var nameCounter = 1;
var dateCounter = 1;
$(document).ready(function () {


    /*----- add textboxes for dates -----*/
    $("#addAccommodationDayButton").click(function () {
        /*  ADD max i min date iz #to i #from
        if (dateCounter > 10) {
        alert("Možete");
        return false;
        }
        */
        dateCounter++;

        var newTextBoxDiv = $(document.createElement('div'))
	     .attr({ id: 'DateTextBoxDiv' + dateCounter, class: 'NamesClass' });

        newTextBoxDiv.after().html('<label>Datum: </label>' +
	      '<input type="text" name="datebox' + dateCounter +
	      '" id="datebox' + dateCounter + '"readonly="readonly" class="Date"/>');

        newTextBoxDiv.appendTo("#DatesGroup");
    });

    $("#removeAccommodationDayButton").click(function () {
        if (dateCounter == 0) {
            alert("Nema više datuma za brisanje");
            return false;
        }

        $("#DateTextBoxDiv" + dateCounter).remove();

        dateCounter--;
    });
    /*----- add textboxes for names -----*/
    $("#addPersonButton").click(function () {

        if (nameCounter > 10) {
            alert("Možete tražiti putne naloge samo za 10 ljudi");
            return false;
        }
        nameCounter++;

        var newTextBoxDiv = $(document.createElement('div'))
	     .attr({ id: 'NamesTextBoxDiv' + nameCounter, class: 'NamesClass' });

        newTextBoxDiv.after().html('<label>Name: </label>' +
	      '<input type="text" name="textbox' + nameCounter +
	      '" id="textbox' + nameCounter + '" value=""/><label> Student:</label><input type="checkbox" name="checkboxStudent' +
          nameCounter + '" id="checkboxStudent' + nameCounter + '"/><label> Suvozač:</label><input type="checkbox" name="checkboxPassenger' +
          nameCounter + '" id="checkboxPassenger' + nameCounter + '"/>');

        newTextBoxDiv.appendTo("#NamesGroup");
    });

    $("#removePersonButton").click(function () {
        if (nameCounter == 1) {
            alert("Mora postojati barem jedna osoba koja ide na put");
            return false;
        }

        $("#TextBoxDiv" + nameCounter).remove();

        nameCounter--;
    });

    /*----- datepickers -----*/
    $("#from").datepicker({
        dateFormat: "dd/mm/yy",
        defaultDate: "+1w",
        onClose: function (selectedDate) {
            $("#to").datepicker("option", "minDate", selectedDate);
        }
    });
    $("#to").datepicker({
        dateFormat: "dd/mm/yy",
        defaultDate: "+1w",
        onClose: function (selectedDate) {
            $("#from").datepicker("option", "maxDate", selectedDate);
        }
    });

    $(document).on("focus", ".Date", function () {
        $(this).datepicker({
            dateFormat: "dd/mm/yy"
        });
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
});

