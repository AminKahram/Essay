using Article.Application.Model.Models.AddEditModels.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Keyword
{
    public class KeywordDBModelUtility
    {
        public static DomainModel.Models.Keyword ToDB (KeywordAddEditModel keyword)
        {
            return new DomainModel.Models.Keyword
            {
                KeywordID = keyword.KeywordID,
                KeywordName = keyword.KeywordName
            };
        }
    }
}
