using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class PurchaseDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Purchase")]
        public int PurchaseId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Remarks { get; set; }

        // setting the foreign key connections  

        public virtual Purchase Purchase { get; set; }

        public virtual Product Product { get; set; }



    }
}
