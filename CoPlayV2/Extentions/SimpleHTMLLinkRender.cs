using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoPlayV2.Extentions
{
    public static class HtmlHelpers
    {

        public static string SimpleLink(this HtmlHelper html, string url, string text)
        {
            return String.Format("<a href=\"{0}\">{1}</a>", url, text);
        }

    }
}