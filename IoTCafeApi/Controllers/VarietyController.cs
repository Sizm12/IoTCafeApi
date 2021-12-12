using IoTCafeApi.Entities;
using IoTCafeApi.Model.Variety.Entities;
using IoTCafeApi.Service.Variety;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTCafeApi.Controllers
{
    [Route("Variety")]
    [ApiController]
    public class VarietyController : ControllerBase
    {
        private IVarietyServices _VarietyServices;
        public VarietyController(IVarietyServices VarietyServices)
        {
            _VarietyServices = VarietyServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            ResponseEntities<List<VarietyEntities>> _Response = new ResponseEntities<List<VarietyEntities>>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = _VarietyServices.GetAll();

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
        public async Task<IActionResult> Insert(VarietyEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _VarietyServices.Create(_Request);

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
        public async Task<IActionResult> Update(VarietyEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _VarietyServices.Update(_Request);

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
                _Response.Result = await _VarietyServices.Status(Id);

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
