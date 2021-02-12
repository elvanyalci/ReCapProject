using Business.Abstract;
using Core.Utilities.Results;
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
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result();
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

        public IResult Insert(Car car)
        {
            if (car.Description.Length < 2)
            {
                return new ErrorResult("araba ismi 2 karakterden düşük olmamalıdır")
            }
             _carDal.Add(car);
            //_carDal.GetAll();
            //return new Result(true,"ürün eklendi");
            return new SuccessResult("ürün eklendi");

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result();

        }
    }
}
