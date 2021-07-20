using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class ReplyService
    {
        private readonly Guid _authorId;

        public ReplyService(Guid authorId)
        {
            _authorId = authorId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    Text = model.Text,
                    CommentId = model.CommentId,
                    AuthorId = _authorId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
