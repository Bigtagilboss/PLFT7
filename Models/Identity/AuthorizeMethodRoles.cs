using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmApp.Models.Identity
{
    [Table("authorize_method_roles")]
    public class AuthorizeMethodRole
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [Column("method_name")]
        public string? MethodName { get; set; }
        [Required]
        [Column("role_id")]
        public string? RoleId { get; set; }
    }
}
