using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Identity
{
    [Table("roles")]
    public class Role
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        [Column("name")]
        [Required]
        public string? Name { get; set; }
    }
}