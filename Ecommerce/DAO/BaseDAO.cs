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
    public class BaseDAO<T> : IDAO<T> where T : BaseRow
    {
        protected readonly Database _database;

        public BaseDAO()
        {
            _database = Database.Instance;
        }

        public List<T> Search(Func<T, bool> predicate)
        {
            return _database.Get<T>().Where(predicate).ToList();
        }

        public int Insert(T row)
        {
            return _database.InsertTable(row);
        }

        public int Update(T row)
        {
            return _database.UpdateTable(row);
        }

        public bool Delete(int id)
        {
            return _database.DeleteTable<T>(id);
        }

        public List<T> FindAll()
        {
            return _database.SelectTable<T>();
        }

        public T FindById(int id)
        {
            return _database.Get<T>().FirstOrDefault(r => r.Id == id);
        }

        public void Clear()
        {
            _database.Get<T>().Clear();
        }
    }
}
