using Ecommerce.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAO
{
    public class Database
    {
        public List<Product> ProductTable { get; set; }
        public List<Category> CategoryTable { get; set; }
        public List<Accessory> AccessoryTable { get; set; }

        private IDictionary<Type, object>? _sets;

        private static Database instance;
        public static Database Instance => instance ?? (instance = new Database());

        public Database()
        {
            ProductTable = new List<Product>();
            CategoryTable = new List<Category>();
            AccessoryTable = new List<Accessory>();
        }

        public List<T> Get<T>() where T : BaseRow
        {
            return (List<T>)typeof(Database)
                .GetProperties() // lấy ra các prop
                .FirstOrDefault(prop => prop.PropertyType == typeof(List<T>)) // select prop có kiểu List<T>
                .GetValue(this); // get value của prop được select
        }

        public int InsertTable<T>(T row) where T : BaseRow
        {
            Get<T>().Add(row);
            return row.Id;
        }

        public List<T> SelectTable<T>() where T : BaseRow
        {
            return Get<T>();
        }

        public int UpdateTable<T>(T row) where T : BaseRow
        {
            var record = Get<T>().Find(r => r.Id == row.Id);
            if (record != null)
            {
                PropertyInfo[] properties = typeof(T).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    if (property.CanRead && property.CanWrite)
                    {
                        var value = property.GetValue(row);
                        property.SetValue(record, value);
                    }
                }
                return row.Id;
            }
            else
            {
                throw new Exception("Can not find row");
            }
        }
        public bool DeleteTable<T>(int id) where T : BaseRow
        {
            var record = Get<T>().Find(r => r.Id == id);
            if (record != null)
            {
                Get<T>().Remove(record);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TruncateTable<T>() where T : BaseRow
        {
            Get<T>().Clear();
        }
    }
}
