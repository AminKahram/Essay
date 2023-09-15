using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Model.Account
{
    public class LogginModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = " * Please enter user name!")]
        [StringLength(200, ErrorMessage = "User name must be between 3 and 200", MinimumLength = 3)]
        public string UserName { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = " * Please enter password!")]
        [StringLength(200, ErrorMessage = "Password must be between 3 and 200", MinimumLength = 3)]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
