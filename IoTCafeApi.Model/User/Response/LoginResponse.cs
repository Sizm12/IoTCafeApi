using IoTCafeApi.Model.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.User.Response
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public UserEntities UserInfo { get; set; }
    }
}
