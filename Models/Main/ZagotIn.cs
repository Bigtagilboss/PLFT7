using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("zagot_in")]
    [Index(nameof(ZagotId), IsUnique = false)]
    [Index(nameof(OperRashodId), IsUnique = false)]
    public class ZagotIn
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Column("zagot_in_id")]
        [Required]
        public string? ZagotId { get; set; }

        [Column("oper_rashod_id")]
        [Required]
        public string? OperRashodId { get; set; }

        [ForeignKey("ZagotId")]
        public Zagot? zagots { get; set; }

        [ForeignKey("OperRashodId")]
        public OperRashod? operRashod { get; set; }
    }
}
