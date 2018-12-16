using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class InputOutputCar:BaseModel
    {
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(64)]
        public string FatherName { get; set; }
        [StringLength(64)]
        public string MotherName { get; set; }
        public int Ci { get; set; }
        [StringLength(64)]
        public string PhoneNumber { get; set; }
        [StringLength(64)]
        public string CarPlate { get; set; }
        [StringLength(64)]
        public string Model { get; set; }
        [StringLength(64)]
        public string Color { get; set; }
        [StringLength(64)]
        public string Brand { get; set; }
        [StringLength(64)]
        public string TypeCar { get; set; }

        public int FirstHour { get; set; }
        public int AdditionalHour { get; set; }

        public DateTime InHour { get; set; }
        public DateTime OutHour { get; set; }
        public float BigTotal { get; set; }
    }
}
