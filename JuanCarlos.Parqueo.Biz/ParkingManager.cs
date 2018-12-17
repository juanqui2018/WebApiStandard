using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Contracts;
using JuanCarlos.Parqueo.Entities;

namespace JuanCarlos.Parqueo.Biz
{
    public class ParkingManager
    {
        private IParkingDao _parkingDao;
        public ParkingManager(IParkingDao parkingDao)
        {
            _parkingDao = parkingDao;
        }

        public Parking StoreParking(Parking parking)
        {
            if (parking != null)
            {
                if (parking.Id == 0)
                {
                    parking.CreatedOn = DateTime.Now;
                    parking.Status = "active";
                    _parkingDao.Create(parking);
                }
                else
                {
                    parking.LastUpdatedOn = DateTime.Now;
                    _parkingDao.Update(parking);
                }
            }
            return parking;
        }

        public Parking GetById(int id)
        {
            var parking = _parkingDao.GetForId(id);
            return parking;
        }

        public bool DeleteParking(int id)
        {
            var parking = _parkingDao.GetForId(id);
            //_parkingDao.Delete(parking);
            parking.Status = "unactive";
            _parkingDao.Update(parking);

            return true;
        }

        public List<Parking> GetAllParkings()
        {
            var parkings = _parkingDao.GetAll().ToList();

            return parkings;
        }
    }
}
