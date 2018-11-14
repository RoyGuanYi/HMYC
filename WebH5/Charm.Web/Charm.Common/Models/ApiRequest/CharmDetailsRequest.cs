using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
 
    public class CharmDetailsRequest : ApiRequestBase
    {
        /// <summary>
        /// 魅力圈id
        /// </summary>
        public String articleId { get; set; }

    }
}
