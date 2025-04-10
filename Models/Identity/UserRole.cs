using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmApp.Models.Identity
{
    [Table("user_roles")]
    public class UserRole
    {
        [Key]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [ForeignKey(nameof(User))]
        [Column("user_id")]
        [Required]
        public string? UserId { get; set; }

        [ForeignKey(nameof(Role))]
        [Column("role_id")]        
        [Required]
        public string? RoleId { get; set; }     
        
        [ForeignKey("UserId")]
        public User? User { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
    }
}