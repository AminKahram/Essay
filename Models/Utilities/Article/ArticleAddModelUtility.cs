using Article.Application.Model.Models.AddEditModels.Article;
using Essay.ViewModel.Article;
using Framework.File;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Models.Utilities.Article
{
    public class ArticleAddModelUtility
    {
        
        public static  ArticleAddEditModel ToAddModel(ArticleAddViewModel viewModel,IWebHostEnvironment hostEnvironment)
        {
           
            ArticleAddEditModel art = new ArticleAddEditModel();
            using (var streamimg = new MemoryStream())
            {
                viewModel.ArticleImage.CopyToAsync(streamimg);
                art.ArticleImage = streamimg.ToArray();

            }
            using (var streamfile = new MemoryStream())
            {
                viewModel.ArticleFile.CopyToAsync(streamfile);
                art.ArticleFile = streamfile.ToArray();
            }
            art.ArticleSubject = viewModel.ArticleSubject;
            art.CategoryID = viewModel.CategoryID;
            art.Description = viewModel.Description;
            art.PublicationDate = viewModel.PublicationDate;
            art.Size = viewModel.Size;
            art.SmallDescription = viewModel.SmallDescription;
            art.KeywordID = viewModel.KeywordID;
       
            string imgfn = viewModel.ArticleImage.FileName;
            string filefn = viewModel.ArticleFile.FileName;

            imgfn = System.IO.Path.GetFileName(imgfn);
            filefn = System.IO.Path.GetFileName(filefn);

            imgfn = imgfn.ToUniqueFileName();
            filefn = filefn.ToUniqueFileName();

            string SavigPathimg = hostEnvironment.WebRootPath + @"/Content/Photos/Article/" + imgfn;
            string SavigPathfile = hostEnvironment.WebRootPath + @"/Content/PDFs/" + filefn;

            FileStream fsimg = new FileStream(SavigPathimg, FileMode.Create);
            FileStream fsfile = new FileStream(SavigPathfile, FileMode.Create);
            
            viewModel.ArticleImage.CopyTo(fsimg);
            viewModel.ArticleFile.CopyTo(fsfile);

            fsimg.Close();
            fsfile.Close();

            art.ArticleImageName = imgfn;
            art.ArticleFileName = filefn;

            return art;
        }
       
    }
}
