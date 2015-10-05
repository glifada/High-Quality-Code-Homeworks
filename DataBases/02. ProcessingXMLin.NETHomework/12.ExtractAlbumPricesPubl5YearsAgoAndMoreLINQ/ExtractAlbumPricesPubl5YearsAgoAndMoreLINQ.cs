using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace _12.ExtractAlbumPricesPubl5YearsAgoAndMoreLINQ
{
    class ExtractAlbumPricesPubl5YearsAgoAndMoreLINQ
    {
        static void Main(string[] args)
        {
            string filePath = "../../../01.Catalogue.xml";
            XDocument xmlDoc = LoadFile(filePath);

            var prices = ExtractAlbumsPublished5YearsAgoAndEarlier(xmlDoc);

            Console.WriteLine("Prices: " + string.Join(", ", prices));
        }

        private static XDocument LoadFile(string filePath)
        {
            XDocument xmlDoc = XDocument.Load(filePath);

            return xmlDoc;
        }

        private static IEnumerable<string> ExtractAlbumsPublished5YearsAgoAndEarlier(XDocument xmlDoc)
        {
            var albumsPrices =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) <= 2010
                select album.Element("price").Value;

            return albumsPrices;
        }
    }
}
