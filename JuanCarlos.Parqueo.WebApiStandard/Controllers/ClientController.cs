using JuanCarlos.Parqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace JuanCarlos.Parqueo.WebApiStandard.Controllers
{
    public class ClientController : BaseApiController
    {
        // GET: Client
        public IEnumerable<Client> GetAllCars()
        {
            return ClientManager.GetAllClients();
        }

        // GET api/Client/5
        public Client GetClient(int id)
        {
            Client client = ClientManager.GetById(id);
            if (client != null)
            {
                return client;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Client
        /// <param name="value"></param>
        public Client PostClient(Client client)
        {
            if (client != null)
            {
                return ClientManager.StoreClient(client);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }


        // PUT api/client/5
        /// <param name="id"></param>
        /// <param name="value"></param>
        public Client Put(int id, [FromBody]Client clientUpdate)
        {
            Client client = ClientManager.GetById(id);

            if (client != null)
            {
                try
                {
                    clientUpdate.Id = client.Id;
                    return ClientManager.StoreClient(clientUpdate);
                }
                catch (Exception e)
                {
                    throw new HttpResponseException(HttpStatusCode.BadRequest);
                }
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Client/5
        /// <param name="id"></param>
        public void DeleteClient(int id)
        {
            Client client = ClientManager.GetById(id);
            if (client != null)
            {
                ClientManager.DeleteClient(client.Id);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}