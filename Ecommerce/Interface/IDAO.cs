using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IDAO<T>
    {
        //Tìm kiếm theo điều kiện
        List<T> Search(Func<T, bool> predicate);

        //Thêm
        int Insert(T row);

        //Sửa
        int Update(T row);

        //Xoá
        bool Delete(int id);

        //Lấy toàn bộ dữ liệu
        List<T> FindAll();

        //Tìm kiếm theo Id
        T FindById(int id);

        //Xoá toàn bộ dữ liệu
        void Clear();
    }
}
