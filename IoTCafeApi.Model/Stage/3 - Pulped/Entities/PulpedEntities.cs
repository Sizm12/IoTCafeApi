using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Stage._3___Pulped.Entities
{
    public class PulpedEntities
    {
        public int Pulpedid { get; set; }
        public DateTime Pulpeddate { get; set; }
        public decimal Pulpedweighprewashed { get; set; }
        public string Pulpedphotoprewashed { get; set; }
        public decimal Pulpedweighpostwashed { get; set; }
        public string Pulpedphotopostwashed { get; set; }
        public int Pulpedplotid { get; set; }
        public bool Pulpedstatus { get; set; }

    }
}
