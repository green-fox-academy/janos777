using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Entities;
using Reddit.Models;
using Microsoft.AspNetCore.Mvc;

namespace Reddit.Repositories
{
    public class PostRepository : IPostRepository
    {
        private RedditContext _context;

        public PostRepository(RedditContext context)
        {
            _context = context;
        }

        public void Create(Post post)
        {
            _context.Add(post);
            _context.SaveChanges();
        }

        public List<Post> Read()
        {
            return _context.Posts.ToList();
        }

        public Post Upvote(int id)
        {
            Post post = GetPostById(id);
            post.Score++;
            _context.SaveChanges();

            return GetPostById(id);
        }

        public Post Downvote(int id)
        {
            Post post = GetPostById(id);
            post.Score--;
            _context.SaveChanges();

            return GetPostById(id);
        }

        public Post GetPostById(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == id);
        }
    }
}
