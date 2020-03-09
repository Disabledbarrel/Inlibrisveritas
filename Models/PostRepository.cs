using InlibrisVeritas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlibrisVeritas.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly BloggDbContext _bloggDbContext;

        public PostRepository(BloggDbContext bloggDbContext)
        {
            _bloggDbContext = bloggDbContext;
        }

        public IEnumerable<Post> AllPosts
        {
            get
            {
                return _bloggDbContext.Posts;
            }
        }

        public Post GetPostById(int postId)
        {
            return _bloggDbContext.Posts.FirstOrDefault(p => p.PostId == postId);
        }
    }
}
