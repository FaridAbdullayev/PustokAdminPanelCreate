using System.ComponentModel.DataAnnotations;

namespace PustokHomework.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        [Required]
        public string Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
