using IoTCafeApi.Data;
using IoTCafeApi.Model.PlotCycle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.PlotCycle
{
    public class PlotCycleServices : IPlotCycleServices
    {
        public async Task<int> Create(PlotCycleEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addplotcycle""", Request.Plotcyclecode, Request.Plotcyclestartdatecycle, Request.Plotcycleenddatecycle, Request.Plotcycleplotid);
        }
    }
}
