using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingJSONinDotNet
{
    class HtmlPage
    {
        private const string videoFormatTemplate = "<a href=\"{0}\">{1}</a> by {2}, published on {3}";

        public void CreateHtmlPage(string path, IEnumerable<Video> videos)
        {
            string html = GenerateHtml(videos);
            CreateFile(path, html);
        }

        private string GenerateHtml(IEnumerable<Video> videos)
        {
            StringBuilder html = new StringBuilder();
            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<body>");
            html.AppendLine("<ul>");

            foreach (Video video in videos)
            {
                html.AppendLine("<li>");
                html.Append(string.Format(videoFormatTemplate, video.Url, video.Title, video.Author, video.Published));
                html.AppendLine("</li>");
                html.AppendLine(string.Format(@"<iframe src=""https://www.youtube.com/embed/{0}"" ></iframe>", video.Id));
            }

            html.AppendLine("</ul>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }

        private void CreateFile(string path, string html)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    sw.WriteLine(html);
                }
            }
        }
    }
}
