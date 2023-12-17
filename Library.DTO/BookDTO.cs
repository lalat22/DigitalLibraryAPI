using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string BookName { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string? Detail { get; set; }

        public decimal Price { get; set; }

        public string? Publication { get; set; }

        public string? Branch { get; set; }

        public int? Quantities { get; set; }

        public int? AvlQuantity { get; set; }

        public int? RentQuantity { get; set; }

        public string? Images { get; set; }

        public string? Pdf { get; set; }

        public DateTime? CreatedBy { get; set; }
    }
}
