using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Disability.Data.Entities
{   
    [Table("DisNews")]
    public class DisNews
    {
        [Required]
        [StringLength(50)]
        public string NewId { set; get; }
        [Required]
        [StringLength(50)]
        public DateTime? CreateDate { set; get; }
        [StringLength(500)]
        public string Name { set; get; }
        public string image { set; get; }
        public string detail { set; get; }

    }
}
