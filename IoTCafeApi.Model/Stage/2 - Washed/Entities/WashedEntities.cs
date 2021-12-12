using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Stage._2___Washed.Entities
{
    public class WashedEntities
    {
        public int Washedid { get; set; }
        public DateTime Washeddate { get; set; }
        public decimal Washedweighprewashed { get; set; }
        public string Washedphotoprewashed { get; set; }
        public decimal Washedweighpostwashed { get; set; }
        public string Washedphotopostwashed { get; set; }
        public int Washedplotid { get; set; }
        public bool Washedstatus { get; set; }
    }
}
