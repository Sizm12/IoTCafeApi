using IoTCafeApi.Data;
using IoTCafeApi.Model.Stage._1___Gather.Entities;
using IoTCafeApi.Model.Stage._2___Washed.Entities;
using IoTCafeApi.Model.Stage._3___Pulped.Entities;
using IoTCafeApi.Model.Stage._4___Fermentation.Entities;
using IoTCafeApi.Model.Stage._5___Drying.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Stage
{
    public class StageServices : IStageServices
    {


        public async Task<int> CreateGather(GatherEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addgather""", Request.Gatherdate, Request.Gatherbrix, Request.Gatherseedhumidity, Request.Gatherphoto, Request.Gatherplotid);
        }
        public async Task<int> CreateWashed(WashedEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addwashed""", Request.Washeddate, Request.Washedweighprewashed, Request.Washedphotoprewashed, Request.Washedweighpostwashed, Request.Washedphotopostwashed, Request.Washedplotid);
        }

        public async Task<int> CreatePulped(PulpedEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addpulped""", Request.Pulpeddate, Request.Pulpedweighprewashed, Request.Pulpedphotoprewashed, Request.Pulpedweighpostwashed, Request.Pulpedphotopostwashed, Request.Pulpedplotid);
        }
        public async Task<int> CreateFermentacion(FermentationEntites Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addfermentation""", Request.Fermentationdate, Request.Fermentationbrix, Request.Fermentationph, Request.Fermentationphoto, Request.Fermentationplotid);
        }

        public async Task<int> CreateDrying(DryingEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_adddrying""", Request.Dryingdate, Request.Dryingweight, Request.Dryinghumidity, Request.Dryingphoto, Request.Dryingplotid);
        }
    }
}
