using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1, car2, car3;
            //Deneme1(out car1, out car2, out car3);

            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(car1);
            //carManager.Delete(car2);
            //carManager.Update(car3);

            foreach (var item in carManager.GetVehicleDetails().Data)
            {
                Console.WriteLine(item.VehicleId + ","+item.BrandName + "," + item.ModelName+","+item.VehicleTypeName);
            }

        }

        private static void Deneme1(out Car car1, out Car car2, out Car car3)
        {
            car1 = new Car
            {
                
                BrandId = 4,
                ColorId = 2,
                DailyPrice = 100,
                Description = "ewqwewqweqweqw",
                FuelTypeId = 2,
                ModelId = 3,
                ModelYear = 1985,
                VehicleTypeId = 11
            };
            car2 = new Car { Id = 2 };
            car3 = new Car { Id = 3, BrandId = 1, ColorId = 1, DailyPrice = 30, Description = "comfortable vehicle", FuelTypeId = 1, ModelId = 1, ModelYear = 2023, VehicleTypeId = 1 };
        }
    }
}
