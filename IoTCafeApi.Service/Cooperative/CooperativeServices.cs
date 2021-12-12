using IoTCafeApi.Data;
using IoTCafeApi.Model.Cooperative.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Cooperative
{
    public class CooperativeServices : ICooperativeServices
    {
        public List<CooperativeEntities> CooperativeGetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<CooperativeEntities> _Result = new List<CooperativeEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<CooperativeEntities>(@"select * from ""public"".""sp_getcooperative""()");
            }
            catch (Exception)
            {

                throw;
            }
            return _Result;
        }

        public async Task<int> CreateCooperative(CooperativeEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();

            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addcooperative""", Request.Cooperativename, Request.Cooperativeaddress, Request.Cooperativeemail, Request.Cooperativephone, Request.Cooperativeuserid);
        }

        public async Task<int> StatusCooperative(int Cooperativeid)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_statuscooperative""", Cooperativeid);
            throw new NotImplementedException();
        }

        public async Task<int> UpdateCooperative(CooperativeEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();

            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_updatecooperative""", Request.Cooperativeid, Request.Cooperativename, Request.Cooperativeaddress, Request.Cooperativephone, Request.Cooperativeemail, Request.Cooperativeuserid);
        }
    }
}
