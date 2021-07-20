using _24Hour.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    class ReplyDetail
    {
        [ForeignKey(nameof(Comment))]
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
