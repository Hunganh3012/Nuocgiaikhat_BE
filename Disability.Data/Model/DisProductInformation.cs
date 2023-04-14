using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Data.Model
{
    public class DisProductInformation
    {
        public string ProductCode { set; get; }
        public string Name { set; get; }
        public decimal? sale { set; get; }
        public decimal priceOld { set; get; }
        public string image { set; get; }
        public string detail { set; get; }

    }
}
