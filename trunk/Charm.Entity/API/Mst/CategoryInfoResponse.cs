using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
    public class CategoryInfoResponse:BaseApiReponse
    {
        public List<CategoryInfo> CateGoryList { get; set; }
    }
}
