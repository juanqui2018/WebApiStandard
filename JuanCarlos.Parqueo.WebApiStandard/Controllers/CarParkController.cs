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
    public class CarParkController : BaseApiController
    {
        // GET: CarPark
        public IEnumerable<CarPark> GetAllCarParks()
        {
            return CarParkManager.GetAllCarParks();
        }

        // GET api/CarPark/5
        public CarPark GetCarPark(int id)
        {
            CarPark carPark = CarParkManager.GetById(id);
            if (carPark != null)
            {
                return carPark;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST api/CarPark
        /// <param name="value"></param>
        public CarPark PostCarPark(CarPark carPark)
        {
            if (carPark != null)
            {
                return CarParkManager.StoreCarPark(carPark);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }


        // PUT api/CarPark/5
        /// <param name="id"></param>
        /// <param name="value"></param>
        public CarPark Put(int id, [FromBody]CarPark carParkUpdate)
        {
            CarPark carPark = CarParkManager.GetById(id);

            if (carPark != null)
            {
                try
                {
                    carParkUpdate.Id = carPark.Id;
                    return CarParkManager.StoreCarPark(carParkUpdate);
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

        // DELETE api/CarPark/5
        /// <param name="id"></param>
        public void DeleteCarPark(int id)
        {
            CarPark carPark = CarParkManager.GetById(id);
            if (carPark != null)
            {
                CarParkManager.DeleteCarPark(carPark.Id);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}