using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Farm.Entities
{
    public class FarmEntities
    {
        public int Farmid { get; set; }
        public string Farmname { get; set; }
        public string Farmaddress { get; set; }
        public decimal Farmlalitude { get; set; }
        public decimal Farmlongitude { get; set; }
        public int Farmphone { get; set; }
        public int Farmcooperativeid { get; set; }
        public int Farmuserid { get; set; }
        public int Farmstationid { get; set; }
        public bool Farmstatus { get; set; }
    }
}
