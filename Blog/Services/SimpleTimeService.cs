using Blog.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Services
{
    public class SimpleTimeService : ITimeService
    {
        public string GetTime() => System.DateTime.Now.ToString("HH:mm:ss");
    }
}
