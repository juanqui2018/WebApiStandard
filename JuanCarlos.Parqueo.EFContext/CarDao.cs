using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Entities;
using JuanCarlos.Parqueo.Contracts;

namespace JuanCarlos.Parqueo.EFContext
{
    public class CarDao:ICarDao
    {
        public CarDao()
        {
        }
        public void Create(Car car)
        {
            using (var context = new ParqueoContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        public void Update(Car car)
        {
            using (var context = new ParqueoContext())
            {
                var carUpdate = context.Cars.SingleOrDefault(x => x.Id == car.Id);
                if (carUpdate != null)
                {
                    carUpdate.LastUpdatedOn = car.LastUpdatedOn;
                    carUpdate.Status = car.Status;
                    carUpdate.Observation = car.Observation;

                    carUpdate.CarPlate = car.CarPlate;
                    carUpdate.Model = car.Model;
                    carUpdate.Color = car.Color;
                    carUpdate.Brand = car.Brand;
                    carUpdate.TypeCar = car.TypeCar;
                }
                context.SaveChanges();
            }
        }
        
        public void Delete(Car car)
        {/*
            using (var context = new ParqueoContext())
            {
                var carDelete = context.Cars.SingleOrDefault(x => x.Id == car.Id);
                context.Cars.Remove(carDelete);
                context.SaveChanges();
            }*/
        }
        
        public Car GetForId(int id)
        {
            Car car;
            using (var context = new ParqueoContext())
            {
                car = context.Cars.SingleOrDefault(x => x.Id == id);
            }
            return car;
        }

        public IEnumerable<Car> GetAll()
        {
            List<Car> cars;
            using (var context = new ParqueoContext())
            {
                cars = context.Cars.Where(x => x.Status != "unactive").ToList();
                //cars = context.Cars.ToList();
            }
            return cars;
        }
    }
}
