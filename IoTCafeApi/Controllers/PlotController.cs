using IoTCafeApi.Entities;
using IoTCafeApi.Model.Plot.Entities;
using IoTCafeApi.Service.Plot;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTCafeApi.Controllers
{
    [Route("Plot")]
    [ApiController]
    public class PlotController : ControllerBase
    {
        private IPlotServices _plotservices;

        public PlotController(IPlotServices plotservices) 
        {
            _plotservices = plotservices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            ResponseEntities<List<PlotEntities>> _Response = new ResponseEntities<List<PlotEntities>>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = _plotservices.GetAll();

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }
        [HttpGet("GetByFarm")]
        public IActionResult GetByFarm(int id)
        {

            ResponseEntities<List<PlotEntities>> _Response = new ResponseEntities<List<PlotEntities>>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = _plotservices.GetByFarm(id);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(PlotEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _plotservices.Create(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(PlotEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _plotservices.Update(_Request);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }

        }

        [HttpPut("Update-State")]
        public async Task<IActionResult> UpdateState(int Id)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _plotservices.Status(Id);

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
