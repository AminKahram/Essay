using Article.Application.Model.Models.AddEditModels.Author;
using Article.DomainModel.Query.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Author
{
    public class AuthorDrpToAddEditModelUtility
    {
        public static AuthorAddEditModel ToAddEdit(DrpAuthorModel drpAuthor)
        {
            return new AuthorAddEditModel
            {
                AuthorID = drpAuthor.AuthorID,
                AuthorName = drpAuthor.AuthorName
            };
        }
    }
}
