using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Main
{
    [Table("cehs")]
    public class Ceh
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        [Column("name")]
        [Required]
        public string? Name { get; set; }        
    }
}