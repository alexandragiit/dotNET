using ClassLibraryNetCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore.model
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string TotalValue { get; set; }
        public string Date { get; set; }
        public int CustomerCustomerId { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<OrderDetails> OrderDetail { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
