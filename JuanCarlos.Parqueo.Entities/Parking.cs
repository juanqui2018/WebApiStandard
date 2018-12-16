using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanCarlos.Parqueo.Entities
{
    public class Parking:BaseModel
    {
        [StringLength(64)]
        public string CodeName { get; set; } 
        public bool Free { get; set; }
        //[Required]
        //[ForeignKey("CarParkId")]
        //public int CarParkId { get; set; }
    }
}
