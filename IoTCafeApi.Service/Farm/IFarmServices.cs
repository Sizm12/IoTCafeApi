using IoTCafeApi.Model.Farm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Farm
{
    public interface IFarmServices
    {
        public List<FarmEntities> FarmGetAll();
        public Task<int> CreateFarm(FarmEntities Request);
        public Task<int> UpdateFarm(FarmEntities Request);
        public Task<int> StatusFarm(int Cooperativeid);
        public Task<int> GetFarmByCooperative(int id);
    }
}
