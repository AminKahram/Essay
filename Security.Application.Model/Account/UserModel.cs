using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Application.Model.Account
{
    public class UserModel
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please enter your user name.")]
        [StringLength(200, ErrorMessage = "User name must be between 3 and 200", MinimumLength = 3)]
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [MinLength(6, ErrorMessage = "طول کلمه عبور حداقل ۶ کاراکتر است")]
        [MaxLength(200,ErrorMessage ="Password must be less than 200 character")]
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(200, ErrorMessage = "First name must be between 3 and 200", MinimumLength = 3)]
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(200, ErrorMessage = "Last name must be between 3 and 200", MinimumLength = 3)]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email address")]

        [StringLength(200, ErrorMessage = "Email must be between 13 and 200", MinimumLength = 13)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        [Display(Name = "شماره تلفن")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please select a Role.")]
        [Display(Name = "نقش")]
        public int RoleID { get; set; }
    }
}
