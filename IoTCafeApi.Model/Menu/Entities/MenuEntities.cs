using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Menu.Entities
{
    public class MenuEntities
    {
        public int Menuid { get; set; }
        public int Menurol { get; set; }
        public string Menuname { get; set; }
        public string Menuurl { get; set; }
        public bool menustatus { get; set; }
        public int Menufatherid { get; set; }
    }
}
