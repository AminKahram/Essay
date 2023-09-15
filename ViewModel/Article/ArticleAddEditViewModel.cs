﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.ViewModel.Article
{
    public class ArticleAddViewModel
    {
        public int ArticleID { get; set; } 
        [Display(Name = "موضوع")]
        [Required(ErrorMessage = " * Please enter subject!")]
        [StringLength(200, ErrorMessage = "Subject must be between 3 and 200", MinimumLength = 3)]
        public string ArticleSubject { get; set; }
        [Display(Name = "عکس")]
        [Required(ErrorMessage = " * Please enter Article Image!")]
        public IFormFile ArticleImage { get; set; }

        [Display(Name = "فایل")]
        [Required(ErrorMessage = " * Please enter File!")]
        public IFormFile ArticleFile { get; set; }
        [Display(Name = "حجم")]
        [Required(ErrorMessage = " * Please enter Size!")]
        public int Size { get; set; }
        [Display(Name = "تاریخ انتشار")]
        [Required(ErrorMessage = " * Please enter publication date!")]
        public DateTime PublicationDate { get; set; }
        [Display(Name = "توضیحات مختصر")]
        [Required(ErrorMessage = " * Please enter small description!")]
        [StringLength(500, ErrorMessage = "Small description must be between 3 and 500", MinimumLength = 3)]
        public string SmallDescription { get; set; }
        [Display(Name = "توضیحات ")]
        [Required(ErrorMessage = " * Please enter description!")]
        [StringLength(4000, ErrorMessage = "Small description must be between 3 and 4000", MinimumLength = 3)]
        public string Description { get; set; }
        [Display(Name = "دسته بندی")]
        [Required(ErrorMessage = " * Please select Category!")]
        public int CategoryID { get; set; }

        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = " * Please enter Author!")]

        public string AuthorID { get; set; }
        [Display(Name = "کلید واژه")]
        [Required(ErrorMessage = " * Please enter Keyword!")]

        public string KeywordID { get; set; }
    }
}