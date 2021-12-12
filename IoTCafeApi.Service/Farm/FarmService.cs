using IoTCafeApi.Data;
using IoTCafeApi.Model.Farm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Farm
{
    public class FarmService : IFarmServices
    {
        public async Task<int> CreateFarm(FarmEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();

            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addfarms""", Request.Farmname, Request.Farmaddress, Request.Farmlalitude, Request.Farmlongitude, Request.Farmphone, Request.Farmcooperativeid, Request.Farmuserid, Request.Farmstationid);
        }

        public List<FarmEntities> FarmGetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<FarmEntities> _Result = new List<FarmEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<FarmEntities>(@"select * from ""public"".""sp_getfarm""()");
            }
            catch (Exception)
            {

                throw;
            }
            return _Result;
        }

        public async Task<int> GetFarmByCooperative(int id)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"select * from ""public"".""sp_findfarmbycooperative""", id);
        }

        public async Task<int> StatusFarm(int id)
        {
            ConnectionData _Cnn = new ConnectionData();

            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_statusfarm""", id);
        }

        public async Task<int> UpdateFarm(FarmEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();

            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_updatefarm""", Request.Farmid, Request.Farmname, Request.Farmaddress, Request.Farmlalitude, Request.Farmlongitude, Request.Farmphone, Request.Farmcooperativeid, Request.Farmuserid, Request.Farmstationid);
        }
    }
}
