using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Services.BaseServices
{
    public interface IBaseRepositorySearchable<TModel,TKey,TSearchModel,TListitemModel>:IBaseRepository<TModel, TKey>
    {
        List<TListitemModel> Search(TSearchModel sm, out int RecordCount);
    }
}
