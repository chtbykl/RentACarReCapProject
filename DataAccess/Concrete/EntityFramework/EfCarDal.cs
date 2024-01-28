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
                var result = from cars in context.Cars

                             join brands in context.Brands
                             on cars.BrandId equals brands.BrandId

                             join colors in context.Colors
                             on cars.ColorId equals colors.ColorId

                             join fuelTypes in context.FuelTypes
                             on cars.FuelTypeId equals fuelTypes.FuelTypeId

                             join models in context.Models
                             on cars.ModelId equals models.ModelId

                             join vehicleTypes in context.VehicleTypes
                             on cars.VehicleTypeId equals vehicleTypes.VehicleTypeId

                             select new VehicleDetailDto
                             {
                                 VehicleId = cars.Id,
                                 BrandName = brands.Name,
                                 ColorCode = colors.ColorCode,
                                 ColorName = colors.Name,
                                 DailyPrice = cars.DailyPrice,
                                 Description = cars.Description,
                                 FuelTypeName = fuelTypes.Name,
                                 ModelName = models.Name,
                                 ModelYear = cars.ModelYear,
                                 VehicleTypeName = vehicleTypes.Name

                             };

                return result.ToList();
            }

        }
       
    }
}
