using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car { CarId = 6, BrandId = 2, ColorId = 8, DailyPrice = 780, ModelYear = 2017, Description = "2017 Model Beyaz Mercedes", CarName = "2017 Model Mercedes"};

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

        }
    }
}
