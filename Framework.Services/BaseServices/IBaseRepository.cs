using Framework.Services.BaseServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Services.BaseServices
{
    public interface IBaseRepository<TModel,TKey>
    {
        OperationResult Add(TModel Current);
        OperationResult Delete(TModel Current);
        OperationResult Update(TModel Current);
        TModel Get(TKey ID);
        List<TModel> GetAll();
    }
}
