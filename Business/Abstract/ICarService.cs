using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        void Insert(Car car);
        void Update(Car car);
        void Delete(Car car);


        List<Car> GetAll();//tümünü listele
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
        List<Car> GetByDailyPrice();
        List<CarDetailDto> GetCarDetails();
        Car GetById(int carId);//id veriyim bana car nesnesi ver

    }
}
