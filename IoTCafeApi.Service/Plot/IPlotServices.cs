using IoTCafeApi.Model.Plot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Plot
{
    public interface IPlotServices
    {
        public List<PlotEntities> GetAll();
        public Task<int> Create(PlotEntities Request);
        public Task<int> Update(PlotEntities Request);
        public Task<int> Status(int id);
        public List<PlotEntities> GetByFarm(int id);
    }
}
