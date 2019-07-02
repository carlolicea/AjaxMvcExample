function changeText(item) {
    alert('test');
    $.ajax({
        type: "POST",
        url: 'home/changetext',
        dataType: "text",
        success: function (result) {
            $("#replaceText").html(result);
        }
    })
}