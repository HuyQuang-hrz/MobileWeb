using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Mã sản phẩm")]
        public string? Name { get; set; }
        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string? Description { get; set; }
        [System.ComponentModel.DisplayName("Mã thương hiệu")]
        public string? ImageUrl { get; set; }
        [System.ComponentModel.DisplayName("Tình trạng")]
        public decimal Price { get; set; }
        [System.ComponentModel.DisplayName("Giá")]
        public int Quantity { get; set; }
        [System.ComponentModel.DisplayName("Số lượng")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category? category { get; set; }
    }
}
