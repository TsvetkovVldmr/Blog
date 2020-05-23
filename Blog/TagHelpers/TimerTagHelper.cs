using Blog.UI.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.TagHelpers
{
    public class TimerTagHelper : TagHelper
    {
        ITimeService timeService;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public TimerTagHelper(ITimeService timeService)
        {
            this.timeService = timeService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // получаем из строки запроса параметр font
            string font = ViewContext?.HttpContext.Request.Query["font"];

            if (String.IsNullOrEmpty(font)) font = "Verdana";

            output.Attributes.SetAttribute("style", $"font-family:{font};font-size:18px;");
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent($"Текущее время: {timeService.GetTime()}");
        }
    }
}
