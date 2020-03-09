using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlibrisVeritas.Models
{
    public class PostRepository : IPostRepository
    {
        public IEnumerable<Post> AllPosts => throw new NotImplementedException();

        public Post GetPostById(int postId)
        {
            throw new NotImplementedException();
        }
    }
}
