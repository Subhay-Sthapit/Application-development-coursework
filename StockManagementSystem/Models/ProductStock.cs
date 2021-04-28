using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class ProductStock
    {
        [Key]
        public int Id { get; set; }
        //[ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        //public virtual Product Product { get; set; }

    }
}
