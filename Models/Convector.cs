using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yomac.Models
{
    public class Convector
    {
        public int Id { get; set; }
        public decimal CRetur { get; set; }
        public decimal CTur { get; set; }
        public decimal CAspiratie { get; set; }
        public decimal CRefulare { get; set; }
        public string DeviceId { get; set; }
        public DateTime ReadAt { get; set; }
    }
}
