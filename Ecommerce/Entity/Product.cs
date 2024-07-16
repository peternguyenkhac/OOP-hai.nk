using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entity
{
    public class Product : BaseRow
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Product: Id: {this.Id}, Name: {this.Name}, CategoryId: {this.CategoryId}");
        }
    }
}
