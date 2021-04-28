using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class SalesDetail
    {
        [Key]
        public int Id { get; set;}
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Sales")]
        public int SalesId { get; set; }
        public int Quantity { get; set; }
        public string Remarks { get; set; }

        // setting up the foreign key connections 

        public virtual Product Product { get; set; }
        public virtual Sales Sales { get; set; }

    }
}
