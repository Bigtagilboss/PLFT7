using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("zagots")]
    public class Zagot
    {
        [Browsable(false)]
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [Column("number")]
        public string? Number { get; set; }
        [Browsable(false)]
        [Required]
        [Column("pasport_id")]
        public string? PasportId { get; set; }

        [Browsable(false)]
        [ForeignKey("PasportId")]
        public Pasport? pasport { get; set; }

        [Browsable(false)]
        [NotMapped]
        public Operation? LastOper { get; set; }

        [NotMapped]
        public string? LastOperName => LastOper?.OperName;

        [Browsable(false)]
        [InverseProperty(nameof(ZagotIn.zagots))]
        public List<ZagotIn>? zagotIn { get; set; }

        [Browsable(false)]
        [InverseProperty(nameof(ZagotOut.zagots))]
        public List<ZagotOut>? zagotOut { get; set; }
    }
}