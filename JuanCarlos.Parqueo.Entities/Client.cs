using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class Client:BaseModel
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int Ci { get; set; }
        public string PhoneNumber { get; set; }

        public List<Car> cars = new List<Car>();
    }
}
