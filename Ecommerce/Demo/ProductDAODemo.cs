using Ecommerce.DAO;
using Ecommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecommerce.Demo
{
    public class ProductDAODemo
    {
        private readonly ProductDAO _productDAO;

        public ProductDAODemo(ProductDAO _productDAO)
        {
            _productDAO = _productDAO;
        }

        //Thêm
        public void InsertTest()
        {
            Product product = new Product()
            {
                Id = 11,
                Name = "New product 11",
                CategoryId = 1,
            };
            _productDAO.Insert(product);
        }

        //Sửa
        public void UpdateTest()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Product 1 updated"
            };
            _productDAO.Update(product);
        }

        //Xoá
        public void DeleteTest()
        {
            int id = 3;
            _productDAO.Delete(id);
        }

        //Tìm theo tên
        public void FindByNameTest()
        {
            string name = "Product 3";
            Product product = _productDAO.FindByName(name);
            Console.WriteLine($"======= product find by Name: {name} ========");
            product.Print();
        }

        //Tìm theo Id
        public void FindByIdTest()
        {
            int id = 4;
            Product product = _productDAO.FindById(id);
            Console.WriteLine($"======= product find by Id: {id} ========");
            product.Print();
        }
    }
}
