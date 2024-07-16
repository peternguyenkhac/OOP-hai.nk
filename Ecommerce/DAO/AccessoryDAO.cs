using Ecommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAO
{
    public class AccessoryDAO : BaseDAO<Accessory>
    {
        public Accessory FindByName(string name)
        {
            return _database.Get<Accessory>().FirstOrDefault(r => r.Name == name);
        }

        public List<Accessory> Search(Func<Accessory, bool> predicate)
        {
            return _database.Get<Accessory>().Where(predicate).ToList();
        }

    }
}
