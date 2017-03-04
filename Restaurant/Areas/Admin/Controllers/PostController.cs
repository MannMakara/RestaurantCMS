using Restaurant.Data;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant.Areas.Admin.Controllers
{
    // Route ("/admin/post")
    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        private readonly IPostRepository _repos;
        public PostController(IPostRepository repository)
        {
            _repos = repository;
        }
        // GET: Admin/Post
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            var model = new Post();
            return View(model);
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("edit/{postId}")]
        public ActionResult Edit(string postId)
        {
            var post = _repos.Get(postId);
            if(post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string postId, Post model)
        {
            var post = _repos.Get(postId);
            if(post == null)
            {
                return HttpNotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _repos.Edit(postId, model);

            return RedirectToAction("index");
        }
    }
}