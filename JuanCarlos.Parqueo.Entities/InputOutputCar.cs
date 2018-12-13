using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class InputOutputCar:BaseModel
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int Ci { get; set; }
        public string PhoneNumber { get; set; }

        public string CarPlate { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string TypeCar { get; set; }

        public int FirstHour { get; set; }
        public int AdditionalHour { get; set; }

        public DateTime InHour { get; set; }
        public DateTime OutHour { get; set; }
        public float BigTotal { get; set; }
    }
}
