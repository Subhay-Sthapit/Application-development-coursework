using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Cat")]
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Remarks { get; set; }

        // setting the foreign key connection
        public virtual Category Cat { get; set; }
    }
}
