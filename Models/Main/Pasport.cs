using AmApp.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("pasports")]
    public class Pasport
    {
        [Key]
        [Browsable(false)]
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [Column("nplav")]
        public string? Nplav { get; set; }
        [Required]
        [Column("npart")]
        public string? Npart { get; set; }
        [Browsable(false)]
        [Required]
        [Column("splav_id")]
        public string? SplavId { get; set; }
        [Required]
        [Column("date_create")]
        public DateTime? DateCreate { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("date_close")]
        public DateTime? DateClose { get; set; }
        [Required]
        [Column("ceh_id")]
        [Browsable(false)]
        public string? CehId { get; set; }
        [Required]
        [Column("user_id")]
        [Browsable(false)]
        public string? UserId { get; set; }
        [Required]
        [Column("tek_id")]
        [Browsable(false)]
        public string? TekId { get; set; }

        [Column("parent_pasport_id")]
        [Browsable(false)]
        public string? ParentPasportId { get; set; }

        [ForeignKey("UserId")]
        [Browsable(false)]
        public User? user{ get; set; }
        [ForeignKey("CehId")]
        [Browsable(false)]
        public Ceh? ceh { get; set; }
        [ForeignKey("SplavId")]
        [Browsable(false)]
        public Splav? splav { get; set; }
        [ForeignKey("TekId")]
        [Browsable(false)]
        public Tek? tek { get; set; }


        [NotMapped]
        public string? UserName => user?.FIO;
        [NotMapped]
        public string? Splav => splav?.Name;
        [NotMapped]
        public string? Ceh => ceh?.Name;
        [NotMapped]
        public string? TekCode => tek?.Code;

    }
}