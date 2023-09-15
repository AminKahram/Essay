using Article.Application.Model.Models.AddEditModels.Article;
using Article.Application.Model.Models.AddEditModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Article
{
    public class DBModelUtility
    {
        public static DomainModel.Models.Article ToDBModel(ArticleAddEditModel addEditModel)
        {
            return new DomainModel.Models.Article
            {
                ArticleID=addEditModel.ArticleID,
                ArticleFile = addEditModel.ArticleFile,
                ArticleFileName=addEditModel.ArticleFileName,
                ArticleImage = addEditModel.ArticleImage,
                ArticleSubject = addEditModel.ArticleSubject,
                CategoryID = addEditModel.CategoryID,
                Description = addEditModel.Description,
                PublicationDate = addEditModel.PublicationDate.Date,
                Size = addEditModel.Size,
                SmallDescription = addEditModel.SmallDescription,
                ArticleImageName = addEditModel.ArticleImageName

            };
        }


        //public static DomainModel.Models.Article ToDBModelEdit(ArticleAddEditModel addEditModel, DomainModel.Models.Article article)
        //
        //    return new DomainModel.Models.Article
        //    {
        //        ArticleID = addEditModel.ArticleID,
        //        ArticleFile = addEditModel.ArticleFile,
        //        ArticleImage = addEditModel.ArticleImage,
        //        ArticleSubject = addEditModel.ArticleSubject,
        //        CategoryID = addEditModel.CategoryID,
        //        Description = addEditModel.Description,
        //        PublicationDate = addEditModel.PublicationDate.Date,
        //        Size = addEditModel.Size,
        //        SmallDescription = addEditModel.SmallDescription,
        //        ArticleImageName = addEditModel.ArticleImageName
        //        ,
        //        Authors = article.Authors,
        //        Keywords = article.Keywords

        //    };
        //}
    }
}
