using AmApp.Models.Identity;
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
    [Table("fact_workers")]
    public class FactWorker
    {
        [Browsable(false)]
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [Column("date_create")]
        public DateTime DateCreate { get; set; } = DateTime.Now.ToUniversalTime();

        [Browsable(false)]
        [Column("date_end")]
        public DateTime? DateEnd { get; set; }

        [Required]
        [Browsable(false)]
        [Column("oborud_id")]
        public string? OborudId { get; set; }

        [Required]
        [Browsable(false)]
        [Column("user_id")]
        public string? UserId { get; set; }

        [Required]
        [Browsable(false)]
        [Column("oper_rashod_id")]
        public string? OperRashodId { get; set; }

        [Browsable(false)]
        [ForeignKey("UserId")]
        public User? user { get; set; }

        [Browsable(false)]
        [ForeignKey("OborudId")]
        public GlobalOborud? globalOborud { get; set; }

        [Browsable(false)]
        [ForeignKey("OperRashodId")]
        public OperRashod? operRashod { get; set; }

        [NotMapped]
        public string? FIO => user?.FIO;
        [NotMapped]
        public string? OborudName => globalOborud?.Name;
    }
}
