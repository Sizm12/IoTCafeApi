using IoTCafeApi.Model.Variety.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Variety
{
     public interface IVarietyServices
    {
        public List<VarietyEntities> GetAll();
        public Task<int> Create(VarietyEntities Request);
        public Task<int> Update(VarietyEntities Request);
        public Task<int> Status(int Cooperativeid);
    }
}
