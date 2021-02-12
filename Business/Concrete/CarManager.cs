using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
            
        }
        public List<Car> GetByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByDailyPrice()
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetail();
        }

        public void Insert(Car car)
        {
             _carDal.Add(car);
            _carDal.GetAll();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
           
        }
    }
}
