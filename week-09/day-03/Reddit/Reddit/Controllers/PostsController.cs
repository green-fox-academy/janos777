using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Controllers;
using Reddit.Models;

namespace Reddit.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _repository;

        public PostsController(IPostRepository repository)
        {
            _repository = repository;
        }

        [HttpGet ("posts")]
        public IActionResult Index()
        {
            return Json(_repository.Read().OrderByDescending(p => p.Score));
        }

        [HttpPost ("posts")]
        public IActionResult Add([FromBody] Post post)
        {
            _repository.Create(post);

            return new OkObjectResult(_repository.GetPostById(post.Id));
        }

        [HttpPut("posts/{id}/upvote")]
        public IActionResult Upvote([FromRoute] int id)
        {
            _repository.Upvote(id);

            return new OkObjectResult(_repository.GetPostById(id));
        }

        [HttpPut("posts/{id}/downvote")]
        public IActionResult Downvote([FromRoute] int id)
        {
            _repository.Downvote(id);

            return new OkObjectResult(_repository.GetPostById(id));
        }
    }
}
