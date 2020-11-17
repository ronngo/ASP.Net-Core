using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tessrt.Models
{
    public class ProductTag
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }
        public Posts Product { get; set; }
        public Tag Tag { get; set; }
    }
}
