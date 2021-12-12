
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IoTCafeApi.Data;

using IoTCafeApi.Model.User.Entities;
using IoTCafeApi.Model.User.Request;
using IoTCafeApi.Model.User.Response;

namespace IoTCafeApi.Service.User
{
    public class UserServices : IUserServices
    {
        public async Task<LoginResponse> Login(LoginRequest Request)
        {
            LoginResponse Response = await Task.Factory.StartNew(() =>
            {
                return new LoginResponse()
                {
                    Token = "Token String",
                    UserInfo = new UserEntities()
                    {
                        UserId = 1,
                        FirstName = "Martin",
                        LastName = "Ramos",
                        UserName = "MRamos"
                    }
                };
            });

            return Response;
        }

        public List<UserEntities> UserGetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<UserEntities> _Result = new List<UserEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<UserEntities>(@"select * from ""Security"".""getallusers""()");
            }
            catch (Exception)
            {

                throw;
            }
            return _Result;
        }
        public async Task<int> Insert(UserEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();

            return await _Cnn.SqlExecuteAsync(@"""Security"".""MyInsert""", Request.FirstName, Request.LastName, Request.UserName, Request.Password, Request.ImageUrl, Request.Email, Request.Phone, Request.RolId, Request.Active);
        }

        public async Task<int> Update(UserEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""Security"".""MyUpdate""", Request.UserId, Request.FirstName, Request.LastName, Request.UserName, Request.Password, Request.ImageUrl, Request.Email, Request.Phone, Request.RolId, Request.Active);
        }
        public async Task<int> Delete(int UserId)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""Security"".""MyDelete""", UserId);
        }




        
    }
}
