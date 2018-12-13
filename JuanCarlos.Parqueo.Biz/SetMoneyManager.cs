using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Contracts;
using JuanCarlos.Parqueo.Entities;

namespace JuanCarlos.Parqueo.Biz
{
    public class SetMoneyManager
    {
        private ISetMoneyDao _setMoneyDao;
        public SetMoneyManager(ISetMoneyDao setMoneyDao)
        {
            _setMoneyDao = setMoneyDao;
        }

        public SetMoney StoreSetMoney(SetMoney setMoney)
        {
            if (setMoney != null)
            {
                if (setMoney.Id == 0)
                {
                    setMoney.CreatedOn = DateTime.Now;
                    _setMoneyDao.Create(setMoney);
                }
                else
                {
                    setMoney.LastUpdatedOn = DateTime.Now;
                    _setMoneyDao.Update(setMoney);
                }
            }
            return setMoney;
        }

        public SetMoney GetById(int id)
        {
            var setMoney = _setMoneyDao.GetForId(id);
            return setMoney;
        }

        public bool DeleteSetMoney(int id)
        {
            var setMoney = _setMoneyDao.GetForId(id);
            _setMoneyDao.Delete(setMoney);

            return true;
        }

        public List<SetMoney> GetAllSetMoneys()
        {
            var setMoneys = _setMoneyDao.GetAll().ToList();

            return setMoneys;
        }
    }
}
