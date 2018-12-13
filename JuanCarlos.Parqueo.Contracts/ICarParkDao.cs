using JuanCarlos.Parqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Contracts
{
    public interface ICarParkDao
    {
        void Create(CarPark carPark);
        void Update(CarPark carPark);
        void Delete(CarPark carPark);
        CarPark GetForId(int id);
        IEnumerable<CarPark> GetAll();
    }
}
