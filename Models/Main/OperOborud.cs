using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("oper_oborud")]
    public class OperOborud
    {
        [Browsable(false)]
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Browsable(false)]
        [Required]
        [Column("tek_oper_id")]
        public string? TekOperId { get; set; }

        [Browsable(false)]
        [Required]
        [Column("oborud_id")]
        public string? OborudId { get; set; }

        [Browsable(false)]
        [ForeignKey("OborudId")]
        public List<GlobalOborud>? GlobalOboruds { get; set; }
    }
}
