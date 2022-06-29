using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Asm1670.Models
{
    public class Cart
    {
        public int Id { get; set; }


        [Range(10, 99, ErrorMessage = "Age Author must be between 10 to 99 old")]
        public int Amount { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
