using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Cooperative.Entities
{
    public class CooperativeEntities
    {
        public int Cooperativeid { get; set; }
        public string Cooperativename { get; set; }
        public string Cooperativeaddress { get; set; }
        public int Cooperativephone { get; set; }
        public string Cooperativeemail { get; set; }
        public int Cooperativeuserid { get; set; }
        public bool Cooperativestatus { get; set; }
    }
}
