using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,200))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }

    
}
