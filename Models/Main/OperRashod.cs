using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AmApp.Models.Identity;

namespace AmApp.Models.Main
{
    [Table("oper_rashod")]
    public class OperRashod
    {
        [Browsable(false)]
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [Column("date_create")]
        public DateTime? DateCreate { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("date_close")]
        public DateTime? DateClose { get; set; }

        [Browsable(false)]
        [Required]
        [Column("oper_id")]
        public string? OperId { get; set; }
        [Browsable(false)]
        [Required]
        [Column("user_id")]
        public string? UserId { get; set; }
        
        [Browsable(false)]
        [ForeignKey("UserId")]
        public User? user { get; set; }

        [Browsable(false)]
        [ForeignKey("OperId")]
        public Operation? operaion { get; set; }

        [Browsable(false)]
        [InverseProperty(nameof(ZagotIn.operRashod))]
        public List<ZagotIn>? zagots { get; set; }

        [Browsable(false)]
        [InverseProperty(nameof(FactZagot.operRashod))]
        public FactZagot? factZagot { get; set; }

        [Browsable(false)]
        [InverseProperty(nameof(FactWorker.operRashod))]
        public List<FactWorker>? factWorkers { get; set; }
    }
}