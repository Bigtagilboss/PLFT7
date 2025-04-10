using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("tek_opers")]
    public class TekOper
    {
        [Browsable(false)]
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Browsable(false)]
        [Required]
        [Column("tek_id")]
        public string? TekId { get; set; }
        [Required]
        [Column("oper_name")]
        public string? OperName { get; set; }

        [Browsable(false)]
        [ForeignKey("TekId")]
        public Tek? tek { get; set; }      
    }
}