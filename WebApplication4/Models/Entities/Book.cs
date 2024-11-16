namespace WebApplication4.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; }
        public int PublicationYear { get; set; }
        public string AuthorId { get; set; }
        public string CategoryId { get; set; }
    }
}
