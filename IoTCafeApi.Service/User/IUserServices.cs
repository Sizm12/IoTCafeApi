using IoTCafeApi.Model.User.Entities;
using IoTCafeApi.Model.User.Request;
using IoTCafeApi.Model.User.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.User
{
    public interface IUserServices
    {
        public Task<LoginResponse> Login(LoginRequest Request);
        public List<UserEntities> UserGetAll();
        public Task<int> Insert(UserEntities Request);
        public Task<int> Update(UserEntities Request);
        public Task<int> Delete(int UserId);
    }
}
