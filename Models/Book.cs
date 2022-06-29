namespace Asm1670.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public int CustomerId { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public Customer Customer { get; set; }
    }
}
