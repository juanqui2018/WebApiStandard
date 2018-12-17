using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Contracts;
using JuanCarlos.Parqueo.Entities;


namespace JuanCarlos.Parqueo.Biz
{
    public class InputOutputCarManager
    {
        private IInputOutputCarDao _inputOutputCarDao;
        public InputOutputCarManager(IInputOutputCarDao inputOutputCarDao)
        {
            _inputOutputCarDao = inputOutputCarDao;
        }

        public InputOutputCar StoreInputOutputCar(InputOutputCar inputOutputCar)
        {
            if (inputOutputCar != null)
            {
                if (inputOutputCar.Id == 0)
                {
                    inputOutputCar.CreatedOn = DateTime.Now;
                    inputOutputCar.Status = "active";
                    _inputOutputCarDao.Create(inputOutputCar);
                }
                else
                {
                    inputOutputCar.LastUpdatedOn = DateTime.Now;
                    _inputOutputCarDao.Update(inputOutputCar);
                }
            }
            return inputOutputCar;
        }

        public InputOutputCar GetById(int id)
        {
            var inputOutputCar = _inputOutputCarDao.GetForId(id);
            return inputOutputCar;
        }

        public bool DeleteInputOutputCar(int id)
        {
            var inputOutputCar = _inputOutputCarDao.GetForId(id);
            //_inputOutputCarDao.Delete(inputOutputCar);
            inputOutputCar.Status = "unactive";
            _inputOutputCarDao.Update(inputOutputCar);

            return true;
        }

        public List<InputOutputCar> GetAllInputOutputCars()
        {
            var inputOutputCars = _inputOutputCarDao.GetAll().ToList();

            return inputOutputCars;
        }
    }
}
