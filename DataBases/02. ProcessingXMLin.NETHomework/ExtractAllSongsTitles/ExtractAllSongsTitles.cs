using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExtractSongsTitles
{
    class ExtractAllSongsTitles
    {
        static void Main(string[] args)
        {
            string xmlFilePath = "../../../01.Catalogue.xml";
            ReadSongsTitles(xmlFilePath);
        }

        private static void ReadSongsTitles (string xmlFilePath)
        {
            Console.WriteLine("Song Titles:");
            using (XmlReader reader = XmlReader.Create(xmlFilePath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
