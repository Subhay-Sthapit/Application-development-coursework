using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        // setting up the foreing key connection 

        public virtual Role Role { get; set; }
    }
}
