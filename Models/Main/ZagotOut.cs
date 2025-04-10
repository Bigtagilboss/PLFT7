using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("zagot_out")]
    [Index(nameof(ZagotId), IsUnique = false)]
    [Index(nameof(FactZagotId), IsUnique = false)]
    public class ZagotOut
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Column("zagot_in_id")]
        [Required]
        public string? ZagotId { get; set; }

        [Column("zagot_out_id")]
        [Required]
        public string? FactZagotId { get; set; }

        [ForeignKey("ZagotId")]
        public Zagot? zagots { get; set; }

        [ForeignKey("FactZagotId")]
        public FactZagot? factZagot { get; set; }
    }
}
