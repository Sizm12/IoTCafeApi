using IoTCafeApi.Entities;
using IoTCafeApi.Model.Cooperative.Entities;
using IoTCafeApi.Service.Cooperative;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTCafeApi.Controllers
{
    [Route("Cooperatives")]
    [ApiController]
    [Authorize]
    public class CooperativeController : ControllerBase
    {
        private ICooperativeServices _CooperativeServices;

        public CooperativeController(ICooperativeServices CooperativeServices)
        {
            _CooperativeServices = CooperativeServices;
        }

        [HttpGet("GetAll")]
        [Authorize(Roles = "administrator")]
        public IActionResult UserGetAll()
        {

            ResponseEntities<List<CooperativeEntities>> _Response = new ResponseEntities<List<CooperativeEntities>>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = _CooperativeServices.CooperativeGetAll();

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
        public async Task<IActionResult> Insert(CooperativeEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _CooperativeServices.CreateCooperative(_Request);

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
        public async Task<IActionResult> Update(CooperativeEntities _Request)
        {

            ResponseEntities<int> _Response = new ResponseEntities<int>();

            try
            {
                _Response.StatusCode = "00";
                _Response.Message = "Success";
                _Response.Result = await _CooperativeServices.UpdateCooperative(_Request);

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
                _Response.Result = await _CooperativeServices.StatusCooperative(Id);

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
