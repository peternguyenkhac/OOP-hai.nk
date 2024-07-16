using Ecommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAO
{
    public class ProductDAO : BaseDAO<Product>
    {
        //Tìm theo tên
        public Product FindByName(string name)
        {
            return _database.Get<Product>().FirstOrDefault(r => r.Name == name);
        }

    }
}
