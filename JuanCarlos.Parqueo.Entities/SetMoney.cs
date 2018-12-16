using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class SetMoney:BaseModel
    {
        public int FirstHour { get; set; }
        public int AdditionalHour { get; set; }

        public virtual CarPark CarPark { get; set; }
    }
}
