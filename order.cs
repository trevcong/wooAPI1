using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wooAPI81
{
    class order
    {
        public int id { get; set; }
        public string status { get; set; }
        public billinginfo billing { get; set; }
    }
}
