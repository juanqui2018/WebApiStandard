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
    public class InputOutputCarController : BaseApiController
    {
        // GET: InputOutputCar
        public IEnumerable<InputOutputCar> GetAllInputOutputCars()
        {
            return InputOutputCarManager.GetAllInputOutputCars();
        }

        // GET api/InputOutputCar/5
        public InputOutputCar GetInputOutputCar(int id)
        {
            InputOutputCar inputOutputCar = InputOutputCarManager.GetById(id);
            if (inputOutputCar != null)
            {
                return inputOutputCar;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST api/InputOutputCar
        /// <param name="value"></param>
        public InputOutputCar PostInputOutputCar(InputOutputCar inputOutputCar)
        {
            if (inputOutputCar != null)
            {
                return InputOutputCarManager.StoreInputOutputCar(inputOutputCar);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }


        // PUT api/InputOutputCar/5
        /// <param name="id"></param>
        /// <param name="value"></param>
        public InputOutputCar Put(int id, [FromBody]InputOutputCar inputOutputCarUpdate)
        {
            InputOutputCar inputOutputCar = InputOutputCarManager.GetById(id);

            if (inputOutputCar != null)
            {
                try
                {
                    inputOutputCarUpdate.Id = inputOutputCar.Id;
                    return InputOutputCarManager.StoreInputOutputCar(inputOutputCarUpdate);
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

        // DELETE api/InputOutputCar/5
        /// <param name="id"></param>
        public void DeleteInputOutputCar(int id)
        {
            InputOutputCar inputOutputCar = InputOutputCarManager.GetById(id);
            if (inputOutputCar != null)
            {
                InputOutputCarManager.DeleteInputOutputCar(inputOutputCar.Id);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}