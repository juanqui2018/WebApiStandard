using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class Client:BaseModel
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

        public virtual ICollection<Car> Cars { get; set; }
    }
}
