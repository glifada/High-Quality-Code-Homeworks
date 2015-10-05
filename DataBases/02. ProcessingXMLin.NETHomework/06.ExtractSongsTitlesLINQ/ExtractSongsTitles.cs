using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _06.ExtractSongsTitlesLINQ
{
    class ExtractSongsTitles
    {
        static void Main(string[] args)
        {
            string xmlFilePath = "../../../01.Catalogue.xml";
            XDocument xmlDoc = XDocument.Load(xmlFilePath);
            ReadSongsTitles(xmlDoc);
        }

        private static void ReadSongsTitles(XDocument xmlDoc)
        {
            var songsTitles = 
                from song in xmlDoc.Descendants("song")
                    select song.Element("title").Value ;

            Console.WriteLine("Song Titles:");
            foreach (var songTitle in songsTitles)
            {
                Console.WriteLine(songTitle);
            }
        }
    }
}
