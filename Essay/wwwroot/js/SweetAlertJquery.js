    function SuccessMessage(SuccessTxt) {
        Swal.fire({
            icon: 'success',
            title: 'وضعیت ثبت',
            text: SuccessTxt,
        });
        }
    function ErrorMessage(ErrorTxt) {
        Swal.fire({
            icon: 'error',
            title: 'خطا',
            text: ErrorTxt,
        });
        }
