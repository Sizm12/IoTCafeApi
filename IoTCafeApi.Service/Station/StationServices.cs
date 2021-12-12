using IoTCafeApi.Data;
using IoTCafeApi.Model.Station.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Station
{
    public class StationServices : IStationServices
    {
        public async Task<int> Create(StationEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addstation""", Request.Stationname, Request.Stationmac, Request.Stationdescription);
        }

        public List<StationEntities> GetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<StationEntities> _Result = new List<StationEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<StationEntities>(@"select * from ""public"".""sp_getstation""()");
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
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_statusstation""", id);
        }

        public async Task<int> Update(StationEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_updatestation""",Request.Stationid, Request.Stationname, Request.Stationmac, Request.Stationdescription);
        }
    }
}
