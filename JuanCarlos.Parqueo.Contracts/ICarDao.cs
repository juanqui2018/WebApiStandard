using JuanCarlos.Parqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Contracts
{
    public interface ICarDao
    {
        void Create(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetForId(int id);
        IEnumerable<Car> GetAll();
    }
}
