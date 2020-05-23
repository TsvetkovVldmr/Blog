using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Views.ViewComponents
{
    [ViewComponent]
    public class Timer : ViewComponent
    {
        public string Invoke(bool includeSeconds)
        {
            if (includeSeconds)
                return $"Текущее время: {DateTime.Now.ToString("hh:mm:ss")}";
            else
                return $"Текущее время: {DateTime.Now.ToString("hh:mm")}";
        }
    }
}
