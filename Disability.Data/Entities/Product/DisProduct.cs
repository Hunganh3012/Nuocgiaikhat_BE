using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Data.Entities
{
    [Table("DisProduct")]
    public class DisProduct
    {
        [Required]
        [StringLength(50)]
        public string ProductCode{set;get;}
        [StringLength(500)]
        public string Name { set; get; }
        public decimal? sale { set; get; }
        public decimal priceOld { set; get; }

        
        public string image { set; get; }
        public string detail { set; get; }

        
        
    }
}
