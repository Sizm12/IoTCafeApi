using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Station.Entities
{
    public class StationEntities
    {
        public int Stationid { get; set; }
        public string Stationname { get; set; }
        public string Stationmac { get; set; }
        public string Stationdescription { get; set; }
        public bool Stationstatus { get; set; }
    }
}
