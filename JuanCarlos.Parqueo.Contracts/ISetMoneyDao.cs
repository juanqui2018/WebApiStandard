using JuanCarlos.Parqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Contracts
{
    public interface ISetMoneyDao
    {
        void Create(SetMoney setMoney);
        void Update(SetMoney setMoney);
        void Delete(SetMoney setMoney);
        SetMoney GetForId(int id);
        IEnumerable<SetMoney> GetAll();
    }
}
