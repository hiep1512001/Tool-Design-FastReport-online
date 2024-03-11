




$(document).ready(function () {

    LoadData()
});
var ListReport;
function loadReportFromDB() {

    var res = validate();
    if (res == false) {
        return false;
    }
    var id = $('#idReport').val();
    var kt = KtIdTonTai(id);
    if (kt == false) {
        alert("Không có report có id=" + id);
        return false;
    }
    window.location.href = "/Home/LoadReportDB/" + id;
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
function KtIdTonTai(id) {
    var isValid = false;
    $.each(ListReport, function (key, item) {
        if (item.id == id) {
            isValid = true;
        }
    });
    return isValid;
}
function LoadData() {
    $.ajax({
        url: '/Home/GetListReport',
        type: 'get',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            console.log(result)
            ListReport = result;
            console.log(ListReport)
            var html = '';
            $.each(result, function (key, item) {
                html += '<option value=' + item.id + ' >' + item.name + '</option>';
            });
            $('#selectName').html(html);
            var select_box_element = document.querySelector('#selectName');
            dselect(select_box_element, {
                search: true
            });
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function changeReport() {
    var idReport = document.querySelector('#selectName').value;
    document.getElementById("idReport").value = idReport;
    $.each(ListReport, function (key, item) {
        if (item.id == idReport) {
            console.log(item);
            document.getElementById("Discription").value = item.description
        }
    });
};