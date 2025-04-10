using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("fact_zagots")]
    public class FactZagot
    {
        [Browsable(false)]
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Browsable(false)]
        [Required]
        [Column("oper_rashod_id")]
        public string? OperRashodId { get; set; }

        [ForeignKey("OperRashodId")]
        [Browsable(false)]
        public OperRashod? operRashod{ get; set; }

        [Browsable(false)]
        [InverseProperty(nameof(ZagotOut.factZagot))]
        public List<ZagotOut>? zagots { get; set; }
    }
}