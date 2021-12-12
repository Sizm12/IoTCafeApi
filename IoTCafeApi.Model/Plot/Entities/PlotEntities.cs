using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Plot.Entities
{
    public class PlotEntities
    {
        public int Plotid { get; set; }
        public string Plotname { get; set; }
        public DateTime Plotstartdatecycle { get; set; }
        public DateTime Plotenddatecycle { get; set; }
        public decimal Plotareadimension { get; set; }
        public string Plotmeasurementtype { get; set; }
        public int Plotvarietyid { get; set; }
        public int Plotfarmid { get; set; }
        public int Plotuserid { get; set; }
        public bool Plotstatus { get; set; }
    }
}
