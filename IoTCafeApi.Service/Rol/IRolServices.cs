using IoTCafeApi.Model.Rol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Rol
{
    public interface IRolServices
    {
        public List<RolEntities> GetAll();
        public Task<int> Create(RolEntities Request);
        public Task<int> Update(RolEntities Request);
        public Task<int> Status(int id);
    }
}
