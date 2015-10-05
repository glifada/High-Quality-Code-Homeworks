using System;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace ProcessingJSONinDotNet
{
    class ProcessingJSONinDotNet
    {
        static void Main(string[] args)
        {
            // Download the content of the feed programatically
            string xmlUri = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileName = "../../rssFeed.xml";
            DownloadXmlFile(xmlUri, fileName);

            // Parse the XML from the feed to JSON
            string jsonFile = ParseXmltoJson(fileName);
            // Console.WriteLine("Json from XML");
            // Console.WriteLine(jsonFile);

            // Using LINQ-to-JSON select all the video titles and print them on the console
            var videosTitles = SelectAllVideoTitlesFromJson(jsonFile);
            Console.WriteLine("Videos Titles:");
            Console.WriteLine(string.Join("\n", videosTitles));
            
            Console.WriteLine(new string('-', 50));

            // Parse the videos' JSON to POCO
            var videos = ParseJsonToPoco(jsonFile);
            Console.WriteLine("Parsed videos' JSON to POCO:");
            Console.WriteLine(string.Join("\n", videos));

            // Using the POCOs create a HTML page that shows all videos from the RSS
            string path = "../../videos.html";
            HtmlPage htmlPage = new HtmlPage();
            htmlPage.CreateHtmlPage(path, videos);
        }

        private static void DownloadXmlFile(string xlmUri, string fileName)
        {
            using (var webClient = new WebClient())
            {
                webClient.DownloadFile(xlmUri, fileName);
            }
        }

        private static string ParseXmltoJson(string fileName)
        {
            XDocument xmlDoc = XDocument.Load(fileName);

            string jsonFile = JsonConvert.SerializeXNode(xmlDoc);

            return jsonFile;
        }

        private static IEnumerable<JToken> SelectAllVideoTitlesFromJson(string jsonFile)
        {
            var jsonObj = JObject.Parse(jsonFile);

            var videosTitles = jsonObj["feed"]["entry"].Select(v => v["title"]);

            return videosTitles;
        }

        private static IEnumerable<Video> ParseJsonToPoco(string jsonFile)
        {
            var jsonObj = JObject.Parse(jsonFile);

            var videos = jsonObj["feed"]["entry"].Select(v => new Video 
            {
                Id = v["yt:videoId"].ToString(),
                Title = v["title"].ToString(),
                Author = v["author"]["name"].ToString(),
                Published = v["published"].ToString(),
                Updated = v["updated"].ToString(),
                Url = "http://www.youtube.com/watch?v=" + v["yt:videoId"].ToString()
        });

            return videos;
        }
    }
}
