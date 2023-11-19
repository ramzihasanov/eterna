using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength:100)]
        [Required]
        public string Title { get; set; }
        [StringLength(maximumLength: 200)]
        [Required]
        public string Desccription { get; set; }
        public string ImageUrl { get; set; }
        public string RedirectUrl { get; set; }
        
    }
}
