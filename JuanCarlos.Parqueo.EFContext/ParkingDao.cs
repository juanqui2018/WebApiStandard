using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Entities;
using JuanCarlos.Parqueo.Contracts;

namespace JuanCarlos.Parqueo.EFContext
{
    public class ParkingDao:IParkingDao
    {
        public ParkingDao()
        {
        }
        public void Create(Parking parking)
        {
            using (var context = new ParqueoContext())
            {
                context.Parkings.Add(parking);
                context.SaveChanges();
            }
        }

        public void Update(Parking parking)
        {
            using (var context = new ParqueoContext())
            {
                var parkingUpdate = context.Parkings.SingleOrDefault(x => x.Id == parking.Id);
                if (parkingUpdate != null)
                {
                    parkingUpdate.LastUpdatedOn = parking.LastUpdatedOn;
                    parkingUpdate.Status = parking.Status;
                    parkingUpdate.Observation = parking.Observation;

                    parkingUpdate.CodeName = parking.CodeName;
                    parkingUpdate.Free = parking.Free;
                }
                context.SaveChanges();
            }
        }

        public void Delete(Parking parking)
        {
            using (var context = new ParqueoContext())
            {
                var parkingDelete = context.Parkings.SingleOrDefault(x => x.Id == parking.Id);
                context.Parkings.Remove(parkingDelete);
                context.SaveChanges();
            }
        }

        public Parking GetForId(int id)
        {
            Parking parking;
            using (var context = new ParqueoContext())
            {
                parking = context.Parkings.SingleOrDefault(x => x.Id == id);
            }
            return parking;
        }

        public IEnumerable<Parking> GetAll()
        {
            List<Parking> parkings;
            using (var context = new ParqueoContext())
            {
                parkings = context.Parkings.Where(x => x.CreatedOn != null).ToList();
            }
            return parkings;
        }
    }
}
