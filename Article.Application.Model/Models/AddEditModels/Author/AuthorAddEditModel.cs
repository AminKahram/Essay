using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Model.Models.AddEditModels.Author
{
    public class AuthorAddEditModel
    {
        public int AuthorID { get; set; }
        [Required(ErrorMessage ="Please enter your author name")]
        [StringLength(200,ErrorMessage ="Author name must be between 3 and 200",MinimumLength =3)]
        [Display(Name ="نویسنده")]
        public string AuthorName { get; set; }
    }
}
