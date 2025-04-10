using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("operations")]
    public class Operation
    {
        [Browsable(false)]
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [Column("sort")]
        public int Sort { get; set; }

        [Required]
        [Column("oper_name")]
        public string? OperName { get; set; }

        [Browsable(false)]
        [Required]
        [Column("pasport_id")]
        public string? PasportId { get; set; }

        [Browsable(false)]
        [Required]
        [Column("tek_oper_id")]
        public string? TekOperId { get; set; }

        [Browsable(false)]
        [ForeignKey("PasportId")]
        public Pasport? pasport { get; set; }

        [Browsable(false)]
        [ForeignKey("TekOperId")]
        public TekOper? tekOper { get; set; }

        [Browsable(false)]
        [InverseProperty(nameof(OperRashod.operaion))]
        public OperRashod? operRashod { get; set; }

    }
}