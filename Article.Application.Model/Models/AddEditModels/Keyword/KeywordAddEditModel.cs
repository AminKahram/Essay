using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Model.Models.AddEditModels.Keyword
{
    public class KeywordAddEditModel
    {
        public int KeywordID { get; set; }
        [Required(ErrorMessage = "Please enter your keyword name")]
        [StringLength(200, ErrorMessage = "Keyword name must be between 3 and 200", MinimumLength = 3)]
        [Display(Name = "کلید واژه")]
        public string KeywordName { get; set; }
    }
}
