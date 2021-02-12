using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCarDal : EfEntityRepositoryBase<Car,NorthwindContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Car
                             join b in context.Brand on c.BrandId equals b.Id
                             join color in context.Color on c.ColorId equals color.Id
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.Name,
                                 ColorName = color.Name,
                                 Description = c.Description
                             };
                return result.ToList();

            }
        }
       
    }
}
