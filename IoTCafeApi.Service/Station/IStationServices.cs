using IoTCafeApi.Model.Station.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Station
{
    public interface IStationServices
    {
        public List<StationEntities> GetAll();
        public Task<int> Create(StationEntities Request);
        public Task<int> Update(StationEntities Request);
        public Task<int> Status(int Cooperativeid);
    }
}
