using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aluru.Model
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        public string content { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public string? image { get; set; }

    }
}
