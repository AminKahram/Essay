using Article.Application.Model.Models.AddEditModels.Article;
using Essay.ViewModel;
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
    public class ArticleEditViewToAddEditModelUtility
    {
        public static ArticleAddEditModel ToAddEditModel(ArticleEditViewModel viewModel, IWebHostEnvironment hostEnvironment)
        {
            ArticleAddEditModel art = new ArticleAddEditModel();
            art.ArticleID = viewModel.ArticleID;
            art.ArticleSubject = viewModel.ArticleSubject;
            art.CategoryID = viewModel.CategoryID;
            art.Description = viewModel.Description;
            art.PublicationDate = viewModel.PublicationDate;
            art.Size = viewModel.Size;
            art.SmallDescription = viewModel.SmallDescription;
           // art.KeywordID = viewModel.KeywordID;
            //put it in action form
            if (viewModel.ArticleImage != null)
            {
                using (var streamimg = new MemoryStream())
                {
                    viewModel.ArticleImage.CopyToAsync(streamimg);
                    art.ArticleImage = streamimg.ToArray();
                    streamimg.Close();
                }

            }
            if (viewModel.ArticleFile != null)
            {
                using (var streamfile = new MemoryStream())
                {
                    viewModel.ArticleFile.CopyToAsync(streamfile);
                    art.ArticleFile = streamfile.ToArray();
                    streamfile.Close();
                }

            }
             if (viewModel.ArticleImage == null)
            {
                string SearchimgFilePath = hostEnvironment.WebRootPath + @"/Content/Photos/Article/" + viewModel.ArticleImageName;
                byte[] fileDataimg = System.IO.File.ReadAllBytes(SearchimgFilePath);
                art.ArticleImage = fileDataimg;

            }
            if (viewModel.ArticleFile == null)
            {
                string SearchFilePath = hostEnvironment.WebRootPath + @"/Content/PDFs/" + viewModel.ArticleFileName;
                byte[] fileData = System.IO.File.ReadAllBytes(SearchFilePath);
                art.ArticleFile = fileData;

            }
            art.ArticleImageName = viewModel.ArticleImageName;
            art.ArticleFileName = viewModel.ArticleFileName;


            //else
            //{
            //    string SearchimgFilePath = hostEnvironment.WebRootPath + @"/Content/Photos/Article/" + viewModel.ArticleImageName;
            //    string SearchFilePath = hostEnvironment.WebRootPath + @"/Content/PDFs/" + viewModel.ArticleFileName;

            //    byte[] fileDataimg = System.IO.File.ReadAllBytes(SearchimgFilePath);
            //    byte[] fileData = System.IO.File.ReadAllBytes(SearchFilePath);


            //    art.ArticleImage = fileDataimg;
            //    art.ArticleFile = fileData;


            //}

            //art.ArticleImageName = viewModel.ArticleImageName;
            //art.ArticleFileName = viewModel.ArticleFileName;
            return art;
           
        }
    }
}
