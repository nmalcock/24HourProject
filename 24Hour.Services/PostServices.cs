using _24Hour.Data;
using _24Hour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Services
{
    public class PostServices
    {
        private readonly Guid _authorId;

        public PostServices (Guid authorId)
        {
            _authorId = authorId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    Title = model.Title,
                    Text = model.Text,
                    AuthorId = _authorId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostListItems> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = 
                    ctx 
                        .Posts
                        .Where (e=> e.AuthorId == _authorId)
                        .Select(
                                e =>
                                new PostListItems
                                {
                                    Id = e.Id,
                                    Title = e.Title,
                                    Text = e.Text
                                }
                         );
                return query.ToArray();
            }
        }
    }
}
