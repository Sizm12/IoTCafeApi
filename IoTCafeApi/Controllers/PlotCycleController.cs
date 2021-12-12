using IoTCafeApi.Entities;
using IoTCafeApi.Model.PlotCycle.Entities;
using IoTCafeApi.Service.PlotCycle;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTCafeApi.Controllers
{
    [Route("PlotCycle")]
    [ApiController]
    public class PlotCycleController : ControllerBase
    {
        private IPlotCycleServices _PlotCycleServices;

        public PlotCycleController(IPlotCycleServices PlotCycleServices)
        {
            _PlotCycleServices = PlotCycleServices;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(PlotCycleEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _PlotCycleServices.Create(_Request);

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
