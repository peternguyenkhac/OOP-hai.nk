using Ecommerce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entity
{
    public abstract class BaseRow : IEntity
    {
        public int Id { get; set; }

        public abstract void Print();
    }
}
