using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DomainModels.MusicBox
{
    public class GenreData
    {
        public int Id { get; set; }
        public string Archetype { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public string Comment { get; set; }
    }
}
