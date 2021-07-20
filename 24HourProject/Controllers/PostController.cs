using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _24Hour.Models;
using _24Hour.Services;

namespace _24HourProject.Controllers
{
    [Authorize]
    public class PostController : ApiController
    {
        public IHttpActionResult Get()
        {
            PostServices postService = CreatePost();
            var posts = postService.GetPosts();
            return Ok(posts);
        }
        public IHttpActionResult Post(PostCreate post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePost();
            if (!service.CreatePost(post))
                return InternalServerError();
            return Ok();
        }
        private PostServices CreatPostService(Guid authorId)
        {
            var userId = Guid.Parse(User.Identity.GetAuthorId());
            var postService = new PostServices(authorId);
            return postService;
        }

    }
}
