using System.ComponentModel.DataAnnotations.Schema;

namespace Aluru.DTO
{
   
    public class AddTeam
    {
        public string name { get; set; }
        public string designation { get; set; }
        public string about { get; set; }
        public string link { get; set; }
        [NotMapped]
        public IFormFile? imageFile { get; set; }
    }
    public class EditTeam
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile? imageFile { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string about { get; set; }
        public string link { get; set; }
    }
}
