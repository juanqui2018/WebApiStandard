using JuanCarlos.Parqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Contracts
{
    public interface IInputOutputCarDao
    {
        void Create(InputOutputCar inputOutputCar);
        void Update(InputOutputCar inputOutputCar);
        void Delete(InputOutputCar inputOutputCar);
        InputOutputCar GetForId(int id);
        IEnumerable<InputOutputCar> GetAll();
    }
}
