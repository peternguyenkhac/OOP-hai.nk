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
    public class CategoryDAODemo
    {
        private readonly CategoryDAO _categoryDAO;

        public CategoryDAODemo(CategoryDAO categoryDAO)
        {
            _categoryDAO = categoryDAO;
        }

        public void InsertTest()
        {
            Category category = new Category()
            {
                Id = 11,
                Name = "New category 11"
            };
            _categoryDAO.Insert(category);
        }

        public void UpdateTest()
        {
            Category category = new Category()
            {
                Id = 1,
                Name = "Category 1 updated"
            };
            _categoryDAO.Update(category);
        }

        public void DeleteTest()
        {
            int id = 2;
            _categoryDAO.Delete(id);
        }

        public void FindByNameTest()
        {
            string name = "Category 3";
            Category category = _categoryDAO.FindByName(name);
            Console.WriteLine($"======= category find by Name: {name} ========");
            category.Print();
        }

        public void FindByIdTest()
        {
            int id = 4;
            Category category = _categoryDAO.FindById(id);
            Console.WriteLine($"======= category find by Id: {id} ========");
            category.Print();
        }
    }
}
