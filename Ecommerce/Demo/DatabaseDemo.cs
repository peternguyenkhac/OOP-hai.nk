using Ecommerce.DAO;
using Ecommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Demo
{
    public class DatabaseDemo
    {
        private readonly ProductDAO _productDAO;
        private readonly CategoryDAO _categoryDAO;
        private readonly AccessoryDAO _accessoryDAO;
        private readonly Database _database;

        public DatabaseDemo(ProductDAO productDAO, CategoryDAO categoryDAO, AccessoryDAO accessoryDAO)
        {
            _productDAO = productDAO;
            _categoryDAO = categoryDAO;
            _accessoryDAO = accessoryDAO;
            _database = Database.Instance;
        }

        //Khởi tạo DB
        public void InitDatabase()
        {
            // init database
            for (int i = 1; i <= 10; i++)
            {
                _productDAO.Insert(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    CategoryId = i
                });
            }

            for (int i = 1; i <= 10; i++)
            {
                _categoryDAO.Insert(new Category
                {
                    Id = i,
                    Name = $"Category {i}"
                });
            }

            for (int i = 1; i <= 10; i++)
            {
                _accessoryDAO.Insert(new Accessory
                {
                    Id = i,
                    Name = $"Accessory {i}"
                });
            }
        }

        //In ra dữ liệu trong bảng
        public void PrintTableTest<T>() where T : BaseRow
        {
            Console.WriteLine($"========= {typeof(T).Name} =========");
            List<T> records = _database.SelectTable<T>();
            if(records.Count > 0)
            {
                foreach (var record in records)
                {
                    record.Print();
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }

        //Thêm 
        public void InsertTableTest()
        {
            Product product = new Product()
            {
                Id = 11,
                Name = "Product 11",
                CategoryId = 1
            };

            _productDAO.Insert(product);
        }

        //Sửa
        public void UpdateTableTest()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Product 1 updated",
                CategoryId = 2
            };

            _productDAO.Update(product);
        }

        //Xoá
        public void DeleteTableTest()
        {
            int id = 2;
            _database.DeleteTable<Product>(id);
        }

        //Xoá toàn bộ dữ liệu
        public void TruncateTable()
        {
            _productDAO.Clear();
        }
    }
}
