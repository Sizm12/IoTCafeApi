using IoTCafeApi.Data;
using IoTCafeApi.Model.Variety.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Variety
{
    public class VarietyServices : IVarietyServices
    {
        public async Task<int> Create(VarietyEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addvariety""", Request.Varietydescripcion);
        }

        public List<VarietyEntities> GetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<VarietyEntities> _Result = new List<VarietyEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<VarietyEntities>(@"select * from ""public"".""sp_getvariety""()");
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
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_statusvariety""", id);
        }

        public async Task<int> Update(VarietyEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_updatevariety""", Request.Varietyid, Request.Varietydescripcion);
        }
    }
}
