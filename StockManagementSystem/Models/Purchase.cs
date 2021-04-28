using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BillNumber { get; set; }
        public string VendorName { get; set; }
    }
}
