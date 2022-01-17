using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Title { get; set; }   
        [Required]
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public Category Category { get; set; }
    }
}
