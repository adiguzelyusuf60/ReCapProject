using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 1300, ModelYear = 2019, Description = "2019 Model Kırmızı Mercedes"},
                new Car{CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 800, ModelYear = 2015, Description = "2015 Model Mavi Skoda"},
                new Car{CarId = 3, BrandId = 5, ColorId = 3, DailyPrice = 13000, ModelYear = 2018, Description = "2018 Model Lacivert Ferrari"},
                new Car{CarId = 4, BrandId = 4, ColorId = 4, DailyPrice = 300, ModelYear = 2012, Description = "2012 Model Siyah Renault"},
                new Car{CarId = 4, BrandId = 3, ColorId = 4, DailyPrice = 580, ModelYear = 2013, Description = "2013 Model Siyah Fiat"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(cD => cD.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);   
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(cU => cU.CarId == car.CarId);

            //Güncellenecek Kısımlar
            car.ColorId = carToUpdate.ColorId;
            car.BrandId = carToUpdate.BrandId;
            car.ModelYear = carToUpdate.ModelYear;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.Description = carToUpdate.Description;

        }
    }
}
