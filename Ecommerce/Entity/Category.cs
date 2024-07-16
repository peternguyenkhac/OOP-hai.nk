using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entity
{
    public class Category : BaseRow
    {
        public string Name { get; set; }
        public override void Print()
        {
            Console.WriteLine($"Category: Id: {this.Id}, Name: {this.Name}");
        }
    }
}
