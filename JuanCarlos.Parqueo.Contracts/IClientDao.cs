using JuanCarlos.Parqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Contracts
{
    public interface IClientDao
    {
        void Create(Client client);
        void Update(Client client);
        void Delete(Client client);
        Client GetForId(int id);
        IEnumerable<Client> GetAll();
    }
}
