using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Contracts;
using JuanCarlos.Parqueo.Entities;

namespace JuanCarlos.Parqueo.Biz
{
    public class CarManager
    {
        private ICarDao _carDao;
        public CarManager(ICarDao carDao)
        {
            _carDao = carDao;
        }

        public Car StoreCar(Car car)
        {
            if (car != null)
            {
                if (car.Id == 0)
                {
                    car.CreatedOn = DateTime.Now;
                    _carDao.Create(car);
                }
                else
                {
                    car.LastUpdatedOn = DateTime.Now;
                    _carDao.Update(car);
                }
            }
            return car;
        }

        public Car GetById(int id)
        {
            var car = _carDao.GetForId(id);
            return car;
        }

        public bool DeleteCar(int id)
        {
            var car = _carDao.GetForId(id);
            _carDao.Delete(car);

            return true;
        }

        public List<Car> GetAllCars()
        {
            var cars = _carDao.GetAll().ToList();

            return cars;
        }
    }
}
