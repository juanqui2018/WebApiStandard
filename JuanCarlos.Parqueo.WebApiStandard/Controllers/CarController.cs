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
    public class CarController : BaseApiController
    {
        // GET: Car
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET api/car
        public IEnumerable<Car> GetAllCars()
        {
            return CarManager.GetAllCars();
        }

        // GET api/car/5
        public Car GetCar(int id)
        {
            Car car = CarManager.GetById(id);
            if (car != null)
            {
                return car;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST api/car
        /// <param name="value"></param>
        public Car PostCar(Car car)
        {
            if (car != null)
            {
                return CarManager.StoreCar(car);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }


        // PUT api/car/5
        /// <param name="id"></param>
        /// <param name="value"></param>
        public Car Put(int id, [FromBody]Car carUpdate)
        {
             Car car = CarManager.GetById(id);
            
            if (car != null)
            {
                try
                {
                    carUpdate.Id = car.Id;
                    return CarManager.StoreCar(carUpdate);
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

        // DELETE api/car/5
        /// <param name="id"></param>
        public void DeleteCar(int id)
        {
            Car car = CarManager.GetById(id);
            if (car != null)
            {
                CarManager.DeleteCar(car.Id);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}