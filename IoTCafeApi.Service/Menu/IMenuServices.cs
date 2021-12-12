using IoTCafeApi.Model.Menu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Menu
{
    public interface IMenuServices
    {
        public List<MenuEntities> GetAll();
        public Task<int> Create(MenuEntities Request);
        public Task<int> Update(MenuEntities Request);
        public Task<int> Status(int id);
    }
}
