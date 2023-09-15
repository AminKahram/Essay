using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Model.Models.AddEditModels.Category
{
    public class CategoryAddEditModel
    { 
        public int CategoryID { get; set; } 
        [Display(Name = "دسته بندی")]
        [Required(ErrorMessage = " * Please enter category name !")]
        [StringLength(200, ErrorMessage = "Category must be between 3 and 200", MinimumLength = 3)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = " * Please enter slug !")]
        [StringLength(200, ErrorMessage = "Category must be between 3 and 200", MinimumLength = 3)]
        public string Slug { get; set; }
        public int? ParentID { get; set; }
        public string KeywordName { get; set; }

        [Display(Name = "کلید واژه")]
        [Required(ErrorMessage = " * Please enter Keyword!")]
        public string KeywordID { get; set; }
    }
}
