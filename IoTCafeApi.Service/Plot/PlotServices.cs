using IoTCafeApi.Data;
using IoTCafeApi.Model.Plot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Plot
{
    public class PlotServices : IPlotServices
    {
        public async Task<int> Create(PlotEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addplot""", Request.Plotname, Request.Plotstartdatecycle, Request.Plotenddatecycle, Request.Plotareadimension, Request.Plotmeasurementtype,  Request.Plotfarmid, Request.Plotuserid, Request.Plotvarietyid);
        }

        public List<PlotEntities> GetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<PlotEntities> _Result = new List<PlotEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<PlotEntities>(@"select * from ""public"".""sp_getplot""()");
            }
            catch (Exception)
            {

                throw;
            }
            return _Result;
        }

        public List<PlotEntities> GetByFarm(int id)
        {
            ConnectionData _Cnn = new ConnectionData();

            List<PlotEntities> _Result = new List<PlotEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<PlotEntities>($"SELECT * from public.sp_findplotbyfarm({id})");
                //_Result = _Cnn.SqlQuery<PlotEntities>(@"select * from ""public"".""sp_findplotbyfarm""", id);
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
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_statusplot""", id);
        }

        public async Task<int> Update(PlotEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_updateplot""", Request.Plotid, Request.Plotname, Request.Plotstartdatecycle, Request.Plotenddatecycle, Request.Plotareadimension, Request.Plotmeasurementtype, Request.Plotfarmid, Request.Plotuserid, Request.Plotvarietyid);
        }
    }
}
