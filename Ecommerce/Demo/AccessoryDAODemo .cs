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
    public class AccessoryDAODemo
    {
        private readonly AccessoryDAO _accessoryDAO;

        public AccessoryDAODemo(AccessoryDAO accessoryDAO)
        {
            _accessoryDAO = accessoryDAO;
        }

        //Thêm
        public void InsertTest()
        {
            Accessory accessory = new Accessory()
            {
                Id = 11,
                Name = "New accessory 11"
            };
            _accessoryDAO.Insert(accessory);
        }

        //Sửa
        public void UpdateTest()
        {
            Accessory accessory = new Accessory()
            {
                Id = 1,
                Name = "Accessory 1 updated"
            };
            _accessoryDAO.Update(accessory);
        }

        //Xoá
        public void DeleteTest()
        {
            int id = 2;
            _accessoryDAO.Delete(id);
        }

        //Tìm theo tên
        public void FindByNameTest()
        {
            string name = "Accessory 4";
            Accessory accessory = _accessoryDAO.FindByName(name);
            Console.WriteLine($"======= accessory find by Name: {name} ========");
            accessory.Print();
        }

        //Tìm theo Id
        public void FindByIdTest()
        {
            int id = 4;
            Accessory accessory = _accessoryDAO.FindById(id);
            Console.WriteLine($"======= accessory find by Id: {id} ========");
            accessory.Print();
        }
    }
}
