using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API
{
    public class BaseApiReponse
    {

        public int RspCode { get; set; }

        public string RspDesc { get; set; }

        public DateTime RspTime = DateTime.Now;

        public int CurrentPage { get; set; }

        public int TotalPage { get; set; }

        public int PageSize { get; set; }
    }
}
