using Ecommerce.DAO;
using Ecommerce.Demo;
using Ecommerce.Entity;

namespace Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDAO productDAO = new ProductDAO();
            CategoryDAO categoryDAO = new CategoryDAO();
            AccessoryDAO accessoryDAO = new AccessoryDAO();

            DatabaseDemo databaseDemo = new DatabaseDemo(productDAO, categoryDAO, accessoryDAO);
            CategoryDAODemo categoryDAODemo = new CategoryDAODemo(categoryDAO);

            databaseDemo.InitDatabase();
            databaseDemo.PrintTableTest<Product>();

            databaseDemo.InsertTableTest();
            databaseDemo.UpdateTableTest();
            databaseDemo.DeleteTableTest();

            databaseDemo.PrintTableTest<Product>();

            databaseDemo.TruncateTable();

            databaseDemo.PrintTableTest<Product>();

            categoryDAODemo.InsertTest();
            categoryDAODemo.UpdateTest();
            categoryDAODemo.DeleteTest();

            databaseDemo.PrintTableTest<Category>();

            categoryDAODemo.FindByNameTest();
            categoryDAODemo.FindByIdTest();
        }
    }
}
