using JuanCarlos.Parqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Contracts
{
    public interface IParkingDao
    {
        void Create(Parking parking);
        void Update(Parking parking);
        void Delete(Parking parking);
        Parking GetForId(int id);
        IEnumerable<Parking> GetAll();
    }
}
