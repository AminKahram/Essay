$(document).ready(function () {
    $(".btnAdd").click(function (e) {
        var isAjax = $(this).attr("data-IsAjax");
        var frm = $(this).attr("data-form");
        var SD = $(frm).serialize();

        var SU = $(this).attr("data-Action");
        if (isAjax === "true") {


            $.post(SU, SD, function (operationResult) {

                if (operationResult.succes) {
                    SuccessMessage(operationResult.message);
                }
                else {
                    ErrorMessage(operationResult.message);
                }
            });
        }


           
    });
    
    $(".btnSearch").click(function (e) {
        var isajax = $(this).attr("data-IsAjax");
        var SU = $(this).attr("data-action");
        var frm = $(this).attr("data-form");
        var SD = $(frm).serialize();
        var t = $(this).attr("data-target");
        if (isajax === "True") {
            e.preventDefault();
            $.get(SU, SD, function (rc) {
                $(t).html(rc);
            })
        }
    })
})
function BindGrid() {
    $(".btnSearch").click();
};

//$(document).on("click", ".btnDelete", function () {
//    if (confirm("Are you sure you want to delete this record ?")) {
//        var SU = $(this).attr("data-action");
//        var SD = $(this).attr("data-id");
//        $.post(SD, SU, function (operationResult) {
//            if (operationResult.succes) {
//                SuccessMessage(operationResult.message);
//                BindGrid();
//            }
//            else {
//                ErrorMessage(operationResult.message);
//            }
//        });
           
//    }

// });
