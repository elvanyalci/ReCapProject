using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=200,Description="Hundai",ModelYear=2010 },
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=500,Description="Transporter",ModelYear=2014 },
                new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=300,Description="Fiat",ModelYear=2013 },
                new Car{Id=4,BrandId=4,ColorId=3,DailyPrice=500,Description="Hundai",ModelYear=2020 },

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public List<Car> GeyById(int id)
        {
            return _car.Where(p => p.ColorId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToDelete =_car.SingleOrDefault(p => p.Id == car.Id);
            carToDelete.Id = car.Id;
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.Description = car.Description;


        }
    }
}
