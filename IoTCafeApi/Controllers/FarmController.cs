using IoTCafeApi.Entities;
using IoTCafeApi.Model.Farm.Entities;
using IoTCafeApi.Service.Farm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTCafeApi.Controllers
{
    [Route("Farms")]
    [ApiController]
    public class FarmController : ControllerBase
    {
        private IFarmServices _FarmServices;

        public FarmController(IFarmServices FarmServices)
        {
            _FarmServices = FarmServices;
        }

        [HttpGet("GetAll")]
        public IActionResult FarmGetAll()
        {

            ResponseEntities<List<FarmEntities>> _Response = new ResponseEntities<List<FarmEntities>>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = _FarmServices.FarmGetAll();

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
        public async Task<IActionResult> Insert(FarmEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _FarmServices.CreateFarm(_Request);

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
        public async Task<IActionResult> Update(FarmEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _FarmServices.UpdateFarm(_Request);

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
                _Response.Result = await _FarmServices.StatusFarm(Id);

                return StatusCode(200, _Response);

            }
            catch (Exception ex)
            {
                _Response.StatusCode = "05";
                _Response.Message = ex.Message;
                return StatusCode(500, _Response);
            }
        }

        [HttpGet("GetByCooperative")]
        public async Task<IActionResult> GetByCooperative(int id)
        {
            ResponseEntities<int> _Response = new ResponseEntities<int>();
            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _FarmServices.GetFarmByCooperative(id);

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
