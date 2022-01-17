using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public List<Post> CategoryPosts { get; set; } = new List<Post>();
    }
}
