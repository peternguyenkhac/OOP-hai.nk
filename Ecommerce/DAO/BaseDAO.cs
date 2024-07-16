using Ecommerce.Entity;
using Ecommerce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ecommerce.DAO
{
    public abstract class BaseDAO<T> : IDAO<T> where T : BaseRow
    {
        protected readonly Database _database;

        public BaseDAO()
        {
            _database = Database.Instance;
        }

        //Tìm kiếm bằng điều kiện
        public List<T> Search(Func<T, bool> predicate)
        {
            return _database.Get<T>().Where(predicate).ToList();
        }

        //Thêm
        public int Insert(T row)
        {
            return _database.InsertTable(row);
        }

        //Sửa
        public int Update(T row)
        {
            return _database.UpdateTable(row);
        }

        //Xoá theo Id
        public bool Delete(int id)
        {
            return _database.DeleteTable<T>(id);
        }

        //Lấy toàn bộ bảng
        public List<T> FindAll()
        {
            return _database.SelectTable<T>();
        }

        //Tìm kiếm bằng Id
        public T FindById(int id)
        {
            return _database.Get<T>().FirstOrDefault(r => r.Id == id);
        }

        //Xoá toàn bộ bảng
        public void Clear()
        {
            _database.Get<T>().Clear();
        }
    }
}
