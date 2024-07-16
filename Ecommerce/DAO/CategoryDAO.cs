using Ecommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAO
{
    public class CategoryDAO : BaseDAO<Category>
    {
        //Tìm theo tên
        public Category FindByName(string name)
        {
            return _database.Get<Category>().FirstOrDefault(r => r.Name == name);
        }
    }
}
