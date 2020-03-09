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
        public IActionResult Create()
        {
            return View();
        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(PostId,Title,Content,ImageUrl, Created")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Add(album);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistID"] = new SelectList(_context.Artist, "ID", "ID", album.ArtistID);
            return View(album);
        }*/
    }
}
