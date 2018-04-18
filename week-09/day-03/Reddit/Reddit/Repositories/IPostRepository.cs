using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Repositories;
using Reddit.Controllers;

namespace Reddit.Repositories
{
    public interface IPostRepository
    {
        void Create(Post post);
        List<Post> Read();
        Post Upvote(int id);
        Post Downvote(int id);
        Post GetPostById(int id);
    }
}
