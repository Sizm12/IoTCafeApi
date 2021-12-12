using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.PlotCycle.Entities
{
    public class PlotCycleEntities
    {
        public int Plotcycleid { get; set; }
        public int Plotcyclecode { get; set; }
        public DateTime Plotcyclestartdatecycle { get; set; }
        public DateTime Plotcycleenddatecycle { get; set; }
        public int Plotcycleplotid { get; set; }
        public bool Plotcyclestatus { get; set; }
    }
}
