using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("splavs")]
    public class Splav
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [Column("name")]
        public string? Name { get; set; }
    }
}
