using IoTCafeApi.Data;
using IoTCafeApi.Model.Menu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Service.Menu
{
    public class MenuServices : IMenuServices
    {
        public async Task<int> Create(MenuEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_addmenu""", Request.Menuname, Request.Menuurl, Request.Menurol, Request.Menufatherid);
        }

        public List<MenuEntities> GetAll()
        {
            ConnectionData _Cnn = new ConnectionData();

            List<MenuEntities> _Result = new List<MenuEntities>();
            try
            {
                _Result = _Cnn.SqlQuery<MenuEntities>(@"select * from ""public"".""sp_getmenu""()");
            }
            catch (Exception)
            {

                throw;
            }
            return _Result;
        }

        public async Task<int> Status(int id)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_statusmenu""", id);

        }

        public async Task<int> Update(MenuEntities Request)
        {
            ConnectionData _Cnn = new ConnectionData();
            return await _Cnn.SqlExecuteAsync(@"""public"".""sp_updatemenu """,Request.Menuid, Request.Menuname, Request.Menuurl, Request.Menurol, Request.Menufatherid);
        }
    }
}
