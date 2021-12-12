using IoTCafeApi.Entities;
using IoTCafeApi.Model.Stage._1___Gather.Entities;
using IoTCafeApi.Model.Stage._2___Washed.Entities;
using IoTCafeApi.Model.Stage._3___Pulped.Entities;
using IoTCafeApi.Model.Stage._4___Fermentation.Entities;
using IoTCafeApi.Model.Stage._5___Drying.Entities;
using IoTCafeApi.Service.Stage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTCafeApi.Controllers
{
    [Route("Stages")]
    [ApiController]
    public class StagesController : ControllerBase
    {
        private IStageServices _StageServices;
        public StagesController(IStageServices StageServices)
        {
            _StageServices = StageServices;
        }

        [HttpPost("InsertGather")]
        public async Task<IActionResult> Insert(GatherEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _StageServices.CreateGather(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPost("InsertWashed")]
        public async Task<IActionResult> Insert(WashedEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _StageServices.CreateWashed(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPost("InsertPulped")]
        public async Task<IActionResult> Insert(PulpedEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _StageServices.CreatePulped(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPost("InsertFermentation")]
        public async Task<IActionResult> Insert(FermentationEntites _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _StageServices.CreateFermentacion(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPost("InsertDrying")]
        public async Task<IActionResult> Insert(DryingEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _StageServices.CreateDrying(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

    }
}
