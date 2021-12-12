using IoTCafeApi.Data;
using IoTCafeApi.Model.Rol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Rol
{
    public class RolServices : IRolServices
    {
        public async Task<int> Create(RolEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addrol""", Request.Rolname);
        }

        public List<RolEntities> GetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<RolEntities> _Result = new List<RolEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<RolEntities>(@"select * from ""public"".""sp_getrol""()");
            }
            catch (Exception)
            {

                throw;
            }
            return _Result;
        }

        public async Task<int> Status(int id)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_statusrol""", id);
        }

        public async Task<int> Update(RolEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_updaterol""", Request.Rolid, Request.Rolname);
        }
    }
}
