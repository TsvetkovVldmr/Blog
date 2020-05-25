using System;
using System.Collections.Generic;
using System.Text;

using Blog.DomainModels;
using Blog.DbTools.Models;
using System.Threading.Tasks;
using Blog.DomainModels.MusicBox;
using DbTools.Models;
using Blog.DbTools.Interfaces;
using System.Diagnostics;

namespace Blog.DbTools.Stores
{
    public class MusicBoxStore : IMusicBoxStore
    {
        public BlogContext DataBase { get; set; }

        public MusicBoxStore()
        {
            DataBase = new BlogContext();
        }

        public async Task AddGenreAsync(GenreData data)
        {
            var genre = new MusicGenre
            {
                Archetype = data.Archetype,
                Genre = data.Genre,
                SubGenre = data.SubGenre,
                Comment = data.Comment
            };

            if (genre == null)
                return;


            string del = "____________________________________\n";
            string msg = $"Archetype => {data.Archetype}\nGenre => {data.Genre}\nSubGenre => {data.SubGenre}\nComment => {data.Comment}\n";

            Debug.WriteLine(del + msg + del);

            await DataBase.MusicGenres.AddAsync(genre);
            await DataBase.SaveChangesAsync();
        }
    }
}
