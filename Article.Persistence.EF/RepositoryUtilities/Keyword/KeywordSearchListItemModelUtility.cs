using Article.DomainModel.Query.Keyword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Persistence.EF.RepositoryUtilities.Keyword
{
    public class KeywordSearchListItemModelUtility
    {
        public static List<KeywordListItemModel> ToSearch(IQueryable<DomainModel.Models.Keyword> keywords, DomainModel.Query.Keyword.KeywordSearchModel sm, out int RecordCount)
        {
            if (!string.IsNullOrEmpty(sm.KeywordName))
            {
                keywords = keywords.Where(x => x.KeywordName.StartsWith(sm.KeywordName));
            }
            RecordCount = keywords.Count();
            return keywords.Select(x => new KeywordListItemModel
            {
                KeywordID = x.KeywordID
            ,
                KeywordName = x.KeywordName
            }).OrderByDescending(x => x.KeywordName).Skip(sm.PageIndex * sm.PageSize).Take(sm.PageSize).ToList();
        }
    }
}
