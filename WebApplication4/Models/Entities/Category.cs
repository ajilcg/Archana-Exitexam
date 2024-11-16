using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
            public string Name { get; set; }
        public string Description { get; set; }

    }
}
