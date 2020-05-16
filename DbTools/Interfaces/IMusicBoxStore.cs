using Blog.DomainModels.MusicBox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DbTools.Interfaces
{
    public interface IMusicBoxStore
    {
        Task AddGenreAsync(GenreData data);
    }
}
