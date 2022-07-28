using System.ComponentModel.DataAnnotations;

namespace MathGameCRUD.Data
{
    public class Post
    {
        [Key]

        public int Id { get; set; }

        [Required]
        [MaxLength(128)]

        public string userName { get; set; }

        [Required]
        

        public Int64 score{ get; set; }
    }
}
