using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Entities;
using JuanCarlos.Parqueo.Contracts;

namespace JuanCarlos.Parqueo.EFContext
{
    public class ClientDao:IClientDao
    {
        public ClientDao()
        {
        }
        public void Create(Client client)
        {
            using (var context = new ParqueoContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        public void Update(Client client)
        {
            using (var context = new ParqueoContext())
            {
                var clientUpdate = context.Clients.SingleOrDefault(x => x.Id == client.Id);
                if (clientUpdate != null)
                {
                    clientUpdate.LastUpdatedOn = client.LastUpdatedOn;
                    clientUpdate.Status = client.Status;
                    clientUpdate.Observation = client.Observation;

                    clientUpdate.Name = client.Name;
                    clientUpdate.FatherName = client.FatherName;
                    clientUpdate.MotherName = client.MotherName;
                    clientUpdate.Ci = client.Ci;
                    clientUpdate.PhoneNumber = client.PhoneNumber;
                }
                context.SaveChanges();
            }
        }

        public void Delete(Client client)
        {
            //using (var context = new ParqueoContext())
            //{
            //    var clientDelete = context.Clients.SingleOrDefault(x => x.Id == client.Id);
            //    context.Clients.Remove(clientDelete);
            //    context.SaveChanges();
            //}
        }

        public Client GetForId(int id)
        {
            Client client;
            using (var context = new ParqueoContext())
            {
                client = context.Clients.SingleOrDefault(x => x.Id == id);
            }
            return client;
        }

        public IEnumerable<Client> GetAll()
        {
            List<Client> clients;
            using (var context = new ParqueoContext())
            {
                clients = context.Clients.Where(x => x.Status != "unactive").ToList();
            }
            return clients;
        }
    }
}
