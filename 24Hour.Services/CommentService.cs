using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class CommentService
    {
        private readonly Guid _authorId;

        public CommentService(Guid authorId)
        {
            _authorId = authorId;
        }

        public bool CreatePost(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    Text = model.Text,
                    PostId = model.PostId,
                    AuthorId = _authorId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public CommentDetail GetCommentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.Id == id && e.AuthorId == _authorId);
                return
                    new CommentDetail
                    {
                        PostId = entity.Id,
                        Text = entity.Text
                    };
            }
        }
    }
}
