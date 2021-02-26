using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car business)
        {
            if (business.CarName.Length >= 2 && business.DailyPrice > 0)
            {
                _carDal.Add(business);
            }
            else
            {
                Console.WriteLine("Girilen araba adı en az 2 karakter, günlük fiyat 0'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car business)
        {
            _carDal.Delete(business);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.Get(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.Get(c => c.ColorId == id);
        }

        public void Update(Car business)
        {
            if (business.CarName.Length >= 2 && business.DailyPrice > 0)
            {
                _carDal.Update(business);
            }
        }
    }
}
