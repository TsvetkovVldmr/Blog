using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.DbTools.Stores;
using Blog.DomainModels.MusicBox;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class MusicBoxController : Controller
    {
        private readonly MusicBoxStore store;

        public MusicBoxController()
        {
            this.store = new MusicBoxStore();
        }

        [HttpPost]
        public async Task Post(GenreData data)
        {
            await this.store.AddGenreAsync(data);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/MusicBox/MusicBoxView.cshtml");
        }
    }
}