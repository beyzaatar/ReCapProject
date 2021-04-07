using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //ColorTest();
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.Getall())
            {
                Console.WriteLine(brand.BrandName);
            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.Getall())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ProductTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
        }
    }
}
