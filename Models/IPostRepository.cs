using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlibrisVeritas.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> AllPosts { get;  }
        Post GetPostById(int postId);
    }
}
