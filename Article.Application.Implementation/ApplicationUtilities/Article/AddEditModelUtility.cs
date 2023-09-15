using Article.Application.Model.Models.AddEditModels.Article;
using Article.DomainModel.Query.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Article
{
    public class AddEditModelUtility 
    {
        public static ArticleAddEditModel ToAddEditModel(ArticleUpdateItemModel updateModel)
        {
            return new ArticleAddEditModel
            {
                ArticleID = updateModel.ArticleID,
                ArticleFile = updateModel.ArticleFile,
                ArticleImage = updateModel.ArticleImage,
                ArticleSubject = updateModel.ArticleSubject,
                CategoryID = updateModel.CategoryID,
                ParentID=updateModel.ParentID,
                AuthorID = updateModel.AuthorID,
                AuthorName=updateModel.AuthorName,
                KeywordID = updateModel.KeywordID,
                KeywordName=updateModel.KeywordName,
                Description = updateModel.Description,
                PublicationDate = updateModel.PublicationDate,
                Size = updateModel.Size,
                SmallDescription = updateModel.SmallDescription,
                ArticleImageName = updateModel.ArticleImageName,
                ArticleFileName=updateModel.ArticleFileName
            };
        }
    }
}
