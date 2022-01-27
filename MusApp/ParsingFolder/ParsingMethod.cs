using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace MusApp.Parsing
{
    class ParsingMethod
    {
        private string url = "https://www.traxsource.com/title/1731185/-weekend-chart-26--last-of-the-year";
        public string GetUrl { get; }

        public (HtmlNodeCollection artist, HtmlNodeCollection title) ParsingNodes()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(this.url);
            var titles = doc.DocumentNode.SelectNodes("//div[@class='trk-cell title']");
            var artist = doc.DocumentNode.SelectNodes("//div[@class='trk-cell artists']");

            return (artist, titles);
        }
     }
}
