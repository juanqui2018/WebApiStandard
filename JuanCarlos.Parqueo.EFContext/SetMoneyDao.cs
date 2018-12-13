using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuanCarlos.Parqueo.Entities;
using JuanCarlos.Parqueo.Contracts;

namespace JuanCarlos.Parqueo.EFContext
{
    public class SetMoneyDao:ISetMoneyDao
    {
        public SetMoneyDao()
        {
        }
        public void Create(SetMoney setMoney)
        {
            using (var context = new ParqueoContext())
            {
                context.SetMoneys.Add(setMoney);
                context.SaveChanges();
            }
        }

        public void Update(SetMoney setMoney)
        {
            using (var context = new ParqueoContext())
            {
                var setMoneyUpdate = context.SetMoneys.SingleOrDefault(x => x.Id == setMoney.Id);
                if (setMoneyUpdate != null)
                {
                    setMoneyUpdate.LastUpdatedOn = setMoneyUpdate.LastUpdatedOn;
                    setMoneyUpdate.Status = setMoneyUpdate.Status;
                    setMoneyUpdate.Observation = setMoneyUpdate.Observation;

                    setMoneyUpdate.FirstHour = setMoneyUpdate.FirstHour;
                    setMoneyUpdate.AdditionalHour = setMoneyUpdate.AdditionalHour;
                    setMoneyUpdate.parking = setMoneyUpdate.parking;
                }
                context.SaveChanges();
            }
        }

        public void Delete(SetMoney setMoney)
        {
            using (var context = new ParqueoContext())
            {
                var setMoneyDelete = context.SetMoneys.SingleOrDefault(x => x.Id == setMoney.Id);
                context.SetMoneys.Remove(setMoneyDelete);
                context.SaveChanges();
            }
        }

        public SetMoney GetForId(int id)
        {
            SetMoney setMoney;
            using (var context = new ParqueoContext())
            {
                setMoney = context.SetMoneys.SingleOrDefault(x => x.Id == id);
            }
            return setMoney;
        }

        public IEnumerable<SetMoney> GetAll()
        {
            List<SetMoney> setMoneys;
            using (var context = new ParqueoContext())
            {
                setMoneys = context.SetMoneys.Where(x => x.CreatedOn != null).ToList();
            }
            return setMoneys;
        }
    }
}
