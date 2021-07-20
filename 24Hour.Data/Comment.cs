using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> c1bd4abe125d83f5bed65fae4f658bc1a827b7cb
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Data
{
    public class Comment
    {
<<<<<<< HEAD
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
=======
        public int Id { get; set; }
        public string Text { get; set; }
>>>>>>> c1bd4abe125d83f5bed65fae4f658bc1a827b7cb
        public Guid AuthorId { get; set; }

        //public virtual List<Reply> replies = new List<Reply>();

        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
