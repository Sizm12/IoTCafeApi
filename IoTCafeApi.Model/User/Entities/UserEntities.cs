using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.User.Entities
{
    public class UserEntities
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int RolId { get; set; }
        public bool Active { get; set; }
    }
}
