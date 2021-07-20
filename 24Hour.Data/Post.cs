using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
<<<<<<< HEAD

        //public virtual List<Comment> Comments { get; set; } = new List<Comment>();
=======
        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
>>>>>>> ada6732f4cb6945c0be95d1c682e60b56113aa68
    }
}
