using Business.Concrete;
using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
   public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            BrandTest();
            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Insert(new Color { Id = 4, Name = "Sarı" });
            //colorManager.Update(new Color { Id = 4, Name = "Değişti" });
            colorManager.Update(new Color { Id = 4 ,Name="yeşil"});
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Id + "  " + color.Name);
            }
            Console.WriteLine( colorManager.GetAll().Message);
        }   

        private static void BrandTest()    
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { Id = 3, Name = "Toyota" });
            //brandManager.Delete(new Brand { Id = 3 });
            foreach (var i in brandManager.GetAll().Data)
            {
                Console.WriteLine(i.Id + " " + i.Name);
            }
            Console.WriteLine("---------");
            var a = brandManager.GetById(2).Message;
            Console.WriteLine(a);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Update(new Car {Id=6,BrandId=2,ColorId=2,ModelYear=1995,DailyPrice=5,Description="değişti"});;



            //foreach (var item in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(item.Description);
            //}
           
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var i in result.Data)
                {
                    Console.WriteLine(i.Description + "/" + i.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
