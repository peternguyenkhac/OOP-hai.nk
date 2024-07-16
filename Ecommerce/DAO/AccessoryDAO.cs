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
        //TÌm theo tên
        public Accessory FindByName(string name)
        {
            return _database.Get<Accessory>().FirstOrDefault(r => r.Name == name);
        }
    }
}
