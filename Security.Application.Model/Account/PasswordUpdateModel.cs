using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Model.Account
{
    public class PasswordUpdateModel
    {
        public int UserID { get; set; }
        [MinLength(6, ErrorMessage = "طول کلمه عبور حداقل ۶ کاراکتر است")]
        [MaxLength(200, ErrorMessage = "Password must be less than 200 character")]
        [Display(Name = "رمز عبور قبلی")]
        [Required(ErrorMessage = "*")]
        public string PastPassword { get; set; }
        [MinLength(6, ErrorMessage = "طول کلمه عبور حداقل ۶ کاراکتر است")]
        [MaxLength(200, ErrorMessage = "Password must be less than 200 character")]
        [Display(Name = "رمز عبور جدید")]
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
        [MinLength(6, ErrorMessage = "طول کلمه عبور حداقل ۶ کاراکتر است")]
        [MaxLength(200, ErrorMessage = "Password must be less than 200 character")]
        [Display(Name = "تکرار رمز عبور جدید")]
        [Required(ErrorMessage = "*")]
        [Compare(nameof(Password), ErrorMessage = "Confirm password mismatch password")]

        public string RePassword { get; set; }

    }
}
