using IoTCafeApi.Model.PlotCycle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.PlotCycle
{
    public interface IPlotCycleServices
    {
        //public List<PlotCycleEntities> GetAll();
        public Task<int> Create(PlotCycleEntities Request);
    }
}
