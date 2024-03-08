$(document).ready(function () {

})
function loadReportFromDB() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var id = $('#idReport').val();
    window.location.href = "/Home/LoadReportDB/" + id;
/*    $.ajax({
        url: '/Home/LoadReportDB/' + id,
        type: 'get',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            console.log(result);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });*/
}
function validate() {
    var isValid = true;
    if ($('#idReport').val().trim() == "") {
        $('#idReport').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#idReport').css('border-color', 'lightgrey');
    }
    return isValid;
}