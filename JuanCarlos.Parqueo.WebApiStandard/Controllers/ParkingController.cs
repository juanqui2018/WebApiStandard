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
    public class ParkingController : BaseApiController
    {
        // GET: Parking
        public IEnumerable<Parking> GetAllParkings()
        {
            return ParkingManager.GetAllParkings();
        }

        // GET api/Parking/5
        public Parking GetParking(int id)
        {
            Parking parking = ParkingManager.GetById(id);
            if (parking != null)
            {
                return parking;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Parking
        /// <param name="value"></param>
        public Parking PostParking(Parking parking)
        {
            if (parking != null)
            {
                return ParkingManager.StoreParking(parking);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }


        // PUT api/Parking/5
        /// <param name="id"></param>
        /// <param name="value"></param>
        public Parking Put(int id, [FromBody]Parking parkingUpdate)
        {
            Parking parking = ParkingManager.GetById(id);

            if (parking != null)
            {
                try
                {
                    parkingUpdate.Id = parking.Id;
                    return ParkingManager.StoreParking(parkingUpdate);
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

        // DELETE api/Parking/5
        /// <param name="id"></param>
        public void DeleteParking(int id)
        {
            Parking parking = ParkingManager.GetById(id);
            if (parking != null)
            {
                ParkingManager.DeleteParking(parking.Id);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}