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
        public async Task<IActionResult> IndexAsync(GenreData data)
        {
            await this.store.AddGenreAsync(data);
            return this.Ok();
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            return View("~/Views/MusicBox/MusicBoxView.cshtml");
        }
    }
}