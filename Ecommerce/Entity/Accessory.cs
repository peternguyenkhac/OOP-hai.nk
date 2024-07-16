using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entity
{
    public class Accessory : BaseRow
    {
        public string Name { get; set; }
        public override void Print()
        {
            Console.WriteLine($"Accessory: Id: {this.Id}, Name: {this.Name}");
        }
    }
}
