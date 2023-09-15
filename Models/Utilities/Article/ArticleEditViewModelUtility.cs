using Article.Application.Model.Models.AddEditModels.Article;
using Essay.ViewModel;
using Essay.ViewModel.Article;
using Framework.File;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Essay.Models.Utilities.Article
{
    public class ArticleEditViewModelUtility
    {
        public static ArticleEditViewModel ToEditModel(ArticleAddEditModel addEditModel)
        {
            ArticleEditViewModel art = new ArticleEditViewModel();

            art.ArticleID = addEditModel.ArticleID;
            art.ArticleSubject = addEditModel.ArticleSubject;
            art.CategoryID = addEditModel.CategoryID;
            art.ParentID = addEditModel.ParentID;
            art.Description = addEditModel.Description;
            art.PublicationDate = addEditModel.PublicationDate;
            art.Size = addEditModel.Size;
            art.SmallDescription = addEditModel.SmallDescription;
            art.ArticleImageName = addEditModel.ArticleImageName;
            art.ArticleFileName = addEditModel.ArticleFileName;
            art.AuthorID = addEditModel.AuthorID;
            art.AuthorName = addEditModel.AuthorName;
            art.KeywordID = addEditModel.KeywordID;
            art.KeywordName = addEditModel.KeywordName;
            
          
            return art;
        }
    }
}
