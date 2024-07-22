using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace StockManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string userName { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } // e.g., "Placed", "Modified", "Cancelled"
        [Required]
        public string Item { get; set; }
    }
}
