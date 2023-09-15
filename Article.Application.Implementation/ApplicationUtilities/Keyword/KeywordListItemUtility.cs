using Article.DomainModel.Query.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Application.Implementation.ApplicationUtilities.Keyword
{
    public class KeywordListItemUtility
    {
        public static List<KeywordListItemModel> ToListItem(List<DomainModel.Models.Keyword> keywords)
        {
            return keywords.Select(x => new KeywordListItemModel { KeywordID = x.KeywordID, KeywordName = x.KeywordName }).ToList();
        }
    }
}
