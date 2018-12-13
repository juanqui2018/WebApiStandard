using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Contracts;
using JuanCarlos.Parqueo.Entities;

namespace JuanCarlos.Parqueo.Biz
{
    public class CarParkManager
    {
        private ICarParkDao _carParkDao;
        public CarParkManager(ICarParkDao carParkDao)
        {
            _carParkDao = carParkDao;
        }

        public CarPark StoreCarPark(CarPark carPark)
        {
            if (carPark != null)
            {
                if (carPark.Id == 0)
                {
                    carPark.CreatedOn = DateTime.Now;
                    _carParkDao.Create(carPark);
                }
                else
                {
                    carPark.LastUpdatedOn = DateTime.Now;
                    _carParkDao.Update(carPark);
                }
            }
            return carPark;
        }

        public CarPark GetById(int id)
        {
            var carPark = _carParkDao.GetForId(id);
            return carPark;
        }

        public bool DeleteCarPark(int id)
        {
            var carPark = _carParkDao.GetForId(id);
            _carParkDao.Delete(carPark);

            return true;
        }

        public List<CarPark> GetAllCarParks()
        {
            var carParks = _carParkDao.GetAll().ToList();

            return carParks;
        }

    }
}