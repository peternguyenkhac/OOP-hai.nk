using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IDAO<T>
    {
        List<T> Search(Func<T, bool> predicate);
        int Insert(T row);
        int Update(T row);
        bool Delete(int id);
        List<T> FindAll();
        T FindById(int id);
        void Clear();
    }
}
