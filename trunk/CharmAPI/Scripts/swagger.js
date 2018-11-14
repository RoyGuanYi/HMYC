$(function () {
    var init = function () {
        $.getJSON($("#input_baseUrl").val(), {}, function (res) {
            $("#resources_container .resource").each(function (i, item) {
                var _id = $(item).attr("id");
                if (!_id) { return; }
                var strSummary = res.ControllerDesc[_id.substring(9)];
                if (strSummary) {
                    $(item).children(".heading").children(".options").prepend('<li style="color:#000">' + strSummary + '</li>');
                }
            });
        });
    };
    init();
});