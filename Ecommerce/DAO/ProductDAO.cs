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
        public Product FindByName(string name)
        {
            return _database.Get<Product>().FirstOrDefault(r => r.Name == name);
        }

        public List<Product> Search(Func<Product, bool> predicate)
        {
            return _database.Get<Product>().Where(predicate).ToList();
        }

    }
}
