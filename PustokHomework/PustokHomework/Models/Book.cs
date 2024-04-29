using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokHomework.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Column(TypeName = "money")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPercent { get; set; }
        public bool StockStatus { get; set; }
        public List<BookImage> Images { get; set; }
        public List<BookTag> BookTags { get; set; }
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }

    }
}
