using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Stage._1___Gather.Entities
{
    public class GatherEntities
    {
        public int Gatherid { get; set; }
        public DateTime Gatherdate { get; set; }
        public decimal Gatherbrix { get; set; }
        public decimal Gatherseedhumidity { get; set; }
        public string Gatherphoto { get; set; }
        public int Gatherplotid { get; set; }
        public bool GatherStatus { get; set; }
    }
}
