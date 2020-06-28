using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagIT.CustomClasses
{
    class CleaningInput
    {
        public string getText(string url)
        {
            var web = new HtmlWeb();
            var doc = web.Load(url);

            //var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            //htmlDoc.LoadHtml(html);

            //var root = htmlDoc.DocumentNode.SelectSingleNode("//body");
            var sb = new StringBuilder();
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()"))
            {
                string wrd = node.InnerText.Trim();
                if (wrd.Trim() != "")
                {
                    sb.AppendLine(wrd);
                }
            }

            return sb.ToString();
        }

    }
}
