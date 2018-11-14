using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
    public  class CategoryInfo
    {
        public string  CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDesc { get; set; }

        public string  ParentId { get; set; }

        public string   SortOrder{ get; set; }

    }
}
