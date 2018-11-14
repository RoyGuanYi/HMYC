using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
     public class GetBrandResponse:BaseApiReponse
    {
        public BrandInfo BrandInfo { get; set; }
    }
}
