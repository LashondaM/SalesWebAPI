using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAPI.Models
{
    public class Order
    {
        public int Id { get; set; } // primary key
        
        [StringLength(80), Required]
        public string Description { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public decimal Total { get; set; }

        public int CustomerId { get; set; } // foreign key

        public virtual Customer Customer { get; set; } // customer instance
        //public virtual Orderline Orderlines { get; set; }

        public Order() { }
    }
}
