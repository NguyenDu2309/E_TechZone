using System.ComponentModel.DataAnnotations;

namespace E_TechZone.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu Tên Thương Hiệu")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu Mô tả Thương Hiệu")]
        public string Description { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; } 
    }
}
