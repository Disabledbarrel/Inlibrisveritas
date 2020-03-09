using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InlibrisVeritas.Models;
using InlibrisVeritas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InlibrisVeritas.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet("Poster")]
        public IActionResult Index()
        {
            PostListViewModel postListViewModel = new PostListViewModel();
            postListViewModel.Posts = _postRepository.AllPosts;

            return View(postListViewModel);
        }
    }
}
