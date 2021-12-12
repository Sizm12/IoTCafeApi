using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Stage._5___Drying.Entities
{
    public class DryingEntities
    {
        public int Dryingid { get; set; }
        public DateTime Dryingdate { get; set; }
        public decimal Dryingweight { get; set; }
        public decimal Dryinghumidity { get; set; }
        public string Dryingphoto { get; set; }
        public int Dryingplotid { get; set; }
        public bool Dryingstatus { get; set; }

    }
}
