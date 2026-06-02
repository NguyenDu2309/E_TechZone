using System.ComponentModel.DataAnnotations;

namespace E_TechZone.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu Tên Sản Phẩm")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu Mô tả Sản Phẩm")]
        public string Description { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu Giá Sản Phẩm")]
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }

        public string Image { get; set; }
    }
}
