﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,ColorId=1,DailyPrice = 550, Description = "A very nice, comfortable vehicle that consumes low fuel.", FuelTypeId = 1, ModelId = 1, ModelYear = 2007, VehicleTypeId = 1},
                new Car {Id=2,ColorId=3,DailyPrice = 450, Description = "A very nice, comfortable vehicle that consumes low fuel.", FuelTypeId = 2, ModelId = 3, ModelYear = 2000, VehicleTypeId = 2},
                new Car {Id=3,ColorId=5,DailyPrice = 350, Description = "A very nice, comfortable vehicle that consumes low fuel.", FuelTypeId = 1, ModelId = 2, ModelYear = 1999, VehicleTypeId = 1}
            };
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            _cars.Remove(_cars.Find(c => c.Id == entity.Id));
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

 

    

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<VehicleDetailDto> GetVehicleDetails(Expression<Func<VehicleDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdated = null;
            carToUpdated = _cars.SingleOrDefault(c => c.Id == entity.Id);

            
            carToUpdated.ColorId = entity.ColorId;
            carToUpdated.ModelId = entity.ModelId;
            carToUpdated.VehicleTypeId = entity.VehicleTypeId;
            carToUpdated.Description = entity.Description;
            carToUpdated.DailyPrice = entity.DailyPrice;
            carToUpdated.FuelTypeId = entity.FuelTypeId;
            carToUpdated.ModelYear = entity.ModelYear;
        }
    }
}
