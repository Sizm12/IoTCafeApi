using IoTCafeApi.Model.Cooperative.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Cooperative
{
    public interface ICooperativeServices
    {
        public List<CooperativeEntities> CooperativeGetAll();
        public Task<int> CreateCooperative(CooperativeEntities Request);
        public Task<int> UpdateCooperative(CooperativeEntities Request);
        public Task<int> StatusCooperative(int Cooperativeid);
    }
}
