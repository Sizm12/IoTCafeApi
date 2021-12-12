using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTCafeApi.Entities
{
    public class ResponseEntities<T>
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
