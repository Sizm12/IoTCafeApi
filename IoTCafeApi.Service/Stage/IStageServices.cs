using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoTCafeApi.Model.Stage._1___Gather.Entities;
using IoTCafeApi.Model.Stage._2___Washed.Entities;
using IoTCafeApi.Model.Stage._3___Pulped.Entities;
using IoTCafeApi.Model.Stage._4___Fermentation.Entities;
using IoTCafeApi.Model.Stage._5___Drying.Entities;

namespace IoTCafeApi.Service.Stage
{
    public interface IStageServices
    {
        public Task<int> CreateGather(GatherEntities Request);
        public Task<int> CreateWashed(WashedEntities Request);
        public Task<int> CreatePulped(PulpedEntities Request);
        public Task<int> CreateFermentacion(FermentationEntites Request);
        public Task<int> CreateDrying(DryingEntities Request);
    }
}
