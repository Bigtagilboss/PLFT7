using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("plavs")]
    public class NPlav
    {
        [Key]
        [Column("nplav")]
        public long Nplav {  get; set; }
    }
}
