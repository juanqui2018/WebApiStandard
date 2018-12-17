using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Contracts;
using JuanCarlos.Parqueo.Entities;

namespace JuanCarlos.Parqueo.Biz
{
    public class ClientManager
    {
        private IClientDao _clientDao;
        public ClientManager(IClientDao clientDao)
        {
            _clientDao = clientDao;
        }

        public Client StoreClient(Client client)
        {
            if (client != null)
            {
                if (client.Id == 0)
                {
                    client.CreatedOn = DateTime.Now;
                    client.Status = "active";
                    _clientDao.Create(client);
                }
                else
                {
                    client.LastUpdatedOn = DateTime.Now;
                    _clientDao.Update(client);
                }
            }
            return client;
        }

        public Client GetById(int id)
        {
            var client = _clientDao.GetForId(id);
            return client;
        }

        public bool DeleteClient(int id)
        {
            var client = _clientDao.GetForId(id);
            //_clientDao.Delete(client);
            client.Status = "unactive";
            _clientDao.Update(client);

            return true;
        }

        public List<Client> GetAllClients()
        {
            var clients = _clientDao.GetAll().ToList();

            return clients;
        }
    }
}
