using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Entities;
using JuanCarlos.Parqueo.Contracts;

namespace JuanCarlos.Parqueo.EFContext
{
    public class CarParkDao:ICarParkDao
    {
        public CarParkDao()
        {
        }
        public void Create(CarPark carPark)
        {
            using (var context = new ParqueoContext())
            {
                context.CarParks.Add(carPark);
                context.SaveChanges();
            }
        }

        public void Update(CarPark carPark)
        {
            using (var context = new ParqueoContext())
            {
                var carParkUpdate = context.CarParks.SingleOrDefault(x => x.Id == carPark.Id);
                if (carParkUpdate != null)
                {
                    carParkUpdate.LastUpdatedOn = carPark.LastUpdatedOn;
                    carParkUpdate.Status = carPark.Status;
                    carParkUpdate.Observation = carPark.Observation;

                    carParkUpdate.Name = carPark.Name;
                    carParkUpdate.Address = carPark.Address;
                    carParkUpdate.CapacityCars = carPark.CapacityCars;
                }
                context.SaveChanges();
            }
        }

        public void Delete(CarPark carPark)
        {
            //using (var context = new ParqueoContext())
            //{
            //    var carParkDelete = context.CarParks.SingleOrDefault(x => x.Id == carPark.Id);
            //    context.CarParks.Remove(carParkDelete);
            //    context.SaveChanges();
            //}
        }

        public CarPark GetForId(int id)
        {
            CarPark carPark;
            using (var context = new ParqueoContext())
            {
                carPark = context.CarParks.SingleOrDefault(x => x.Id == id);
            }
            return carPark;
        }

        public IEnumerable<CarPark> GetAll()
        {
            List<CarPark> carParks;
            using (var context = new ParqueoContext())
            {
                carParks = context.CarParks.Where(x => x.Status != "unactive").ToList();
            }
            return carParks;
        }
    }
}
