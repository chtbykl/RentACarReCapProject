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

            //carManager.Add(car1);
            //carManager.Delete(car2);
            //carManager.Update(car3);

            //Test1();

            //test2();


            RentalManager rentalManager = new RentalManager(new EfRentalDal(),new CarManager(new EfCarDal()));

            //Console.WriteLine( rentalManager.Add(
            //    new Rental 
            //    {
            //        CarId = 7, 
            //        CustomerId = 1, 
            //        RentDate = DateTime.Now, 
            //        ReturnDate = null 
            //    }).Message);

           
            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.CarId + "|| "+item.RentDate + "|| " + item.ReturnDate);
            }

        }

        private static void test2()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + ", " + user.LastName);
            }
            Console.WriteLine(userManager.GetAll().Message);
        }

        private static void Test1()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetVehicleDetails().Data)
            {
                Console.WriteLine(item.VehicleId + "," + item.BrandName + "," + item.ModelName + "," + item.VehicleTypeName);
            }
            Console.WriteLine(carManager.GetVehicleDetails().Message);
        }

        private static void Deneme1(out Car car1, out Car car2, out Car car3)
        {
            car1 = new Car
            {
                
                
                ColorId = 2,
                DailyPrice = 100,
                Description = "ewqwewqweqweqw",
                FuelTypeId = 2,
                ModelId = 3,
                ModelYear = 1985,
                VehicleTypeId = 11
            };
            car2 = new Car { Id = 2 };
            car3 = new Car { Id = 3, ColorId = 1, DailyPrice = 30, Description = "comfortable vehicle", FuelTypeId = 1, ModelId = 1, ModelYear = 2023, VehicleTypeId = 1 };
        }
    }
}
