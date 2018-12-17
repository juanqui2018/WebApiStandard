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
    public class SetMoneyController : BaseApiController
    {
        // GET: SetMoney
        public IEnumerable<SetMoney> GetAllSetMoneys()
        {
            return SetMoneyManager.GetAllSetMoneys();
        }

        // GET api/SetMoney/5
        public SetMoney GetSetMoney(int id)
        {
            SetMoney setMoney = SetMoneyManager.GetById(id);
            if (setMoney != null)
            {
                return setMoney;
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // POST api/SetMoney
        /// <param name="value"></param>
        public SetMoney PostSetMoney(SetMoney setMoney)
        {
            if (setMoney != null)
            {
                return SetMoneyManager.StoreSetMoney(setMoney);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }


        // PUT api/SetMoney/5
        /// <param name="id"></param>
        /// <param name="value"></param>
        public SetMoney Put(int id, [FromBody]SetMoney setMoneyUpdate)
        {
            SetMoney setMoney = SetMoneyManager.GetById(id);

            if (setMoney != null)
            {
                try
                {
                    setMoneyUpdate.Id = setMoney.Id;
                    return SetMoneyManager.StoreSetMoney(setMoneyUpdate);
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

        // DELETE api/setMoney/5
        /// <param name="id"></param>
        public void DeleteSetMoney(int id)
        {
            SetMoney setMoney = SetMoneyManager.GetById(id);
            if (setMoney != null)
            {
                SetMoneyManager.DeleteSetMoney(setMoney.Id);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}