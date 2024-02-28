using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {

        public List<VehicleDetailDto> GetVehicleDetails(Expression<Func<VehicleDetailDto, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var ModelDetails= from models in context.Models
                                   join brands in context.Brands
                                   on models.BrandId equals brands.BrandId

                                   select new ModelDetailDto
                                   {
                                       ModelId = models.ModelId,
                                       ModelName = models.Name,
                                       BrandName = brands.Name
                                   };
                                   

                var CarsDetails = from cars in context.Cars

                             join colors in context.Colors
                             on cars.ColorId equals colors.ColorId

                             join fuelTypes in context.FuelTypes
                             on cars.FuelTypeId equals fuelTypes.FuelTypeId

                             join models in ModelDetails
                             on cars.ModelId equals models.ModelId

                             join vehicleTypes in context.VehicleTypes
                             on cars.VehicleTypeId equals vehicleTypes.VehicleTypeId

                             

                             select new VehicleDetailDto
                             {
                                 VehicleId = cars.Id,
                                 BrandName = models.BrandName,
                                 ColorCode = colors.ColorCode,
                                 ColorName = colors.Name,
                                 DailyPrice = cars.DailyPrice,
                                 Description = cars.Description,
                                 FuelTypeName = fuelTypes.Name,
                                 ModelName = models.ModelName,
                                 ModelYear = cars.ModelYear,
                                 VehicleTypeName = vehicleTypes.Name

                             };
                
                return CarsDetails.ToList();
            }

        }
       
    }
}
