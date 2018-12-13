using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class Parking:BaseModel
    {
        public string CodeName { get; set; } //maybe number
        public bool Free { get; set; }

        public SetMoney setMoney { get; set; }
    }
}
