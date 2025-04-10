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
    [Table("teks")]
    public class Tek
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [Column("code")]
        public string? Code { get; set; }

        [Browsable(false)]
        [Required]
        [Column("ceh_id")]
        public string? CehId { get; set; }

        [Browsable(false)]
        [ForeignKey("CehId")]
        public Ceh? ceh { get; set; }

        [Browsable(false)]
        [InverseProperty(nameof(TekOper.tek))]
        public List<TekOper>? tekOpers { get; set; }
    }
}
