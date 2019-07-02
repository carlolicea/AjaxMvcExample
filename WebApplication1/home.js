function changeText(item) {
    $.ajax({
        type: "POST",
        url: 'word/changetext',
        dataType: "text",
        success: function (result) {
            $("#replaceText").html(result);
            $("#replaceText").css("font-size", "25px");
            $("#replaceText").css("color", "red");
        }
    })
}