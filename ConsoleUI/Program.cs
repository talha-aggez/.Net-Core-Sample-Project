using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID 
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //PersonelTest();
            ProductTest();
            //IoC ile halledicez....
            //CategoryTest();
        }   //DTO DATA TRANSFORMATION OBJECT...

        private static void PersonelTest()
        {
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var item in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}", item.Id, item.Name, item.Surname);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / " + item.CategoryId);
                }
            }
            else
                Console.WriteLine(result.Message);
        }
    }
}
