using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName?.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Hata araba eklenemedi!!!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.CarId == carId);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colordId)
        {
            return _carDal.GetAll(c => c.ColorId == colordId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
