using Article.Application.Model.Models.AddEditModels.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Keyword
{
    public class KeywordAddEditModelUtility
    {
        public static KeywordAddEditModel ToAddEdit(DomainModel.Models.Keyword keyword)
        {
            return new KeywordAddEditModel
            {
                KeywordID = keyword.KeywordID,
                KeywordName = keyword.KeywordName
            };
        }
    }
}
