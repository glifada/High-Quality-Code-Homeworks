using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace _11.ExtractAlbumPricesPublished5YearsAgo
{
    class ExtractAlbumPricesPublished5YearsAgo
    {
        static void Main(string[] args)
        {
            string filePath = "../../../01.Catalogue.xml";
            XmlDocument xmlDoc = LoadFile(filePath);

            XmlNodeList albums = ExtractAlbumsPublished5YearsAgoAndEarlier(xmlDoc);
            IList<double> prices = ExtractPrices(albums);

            Console.WriteLine("Prices: " + string.Join(", ", prices));
        }

        private static XmlDocument LoadFile(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            return xmlDoc;
        }

        private static XmlNodeList ExtractAlbumsPublished5YearsAgoAndEarlier(XmlDocument xmlDoc)
        {
            string xPathQuery = "/catalogue/album[year <= 2010]";

            XmlNodeList albums = xmlDoc.SelectNodes(xPathQuery);

            return albums;
        }

        private static IList<double> ExtractPrices(XmlNodeList albums)
        {
            List<double> albumPrices = new List<double>();

            foreach (XmlNode album in albums)
            {
                double albumPrice = double.Parse(album.SelectSingleNode("price").InnerText);
                albumPrices.Add(albumPrice);
            }

            return albumPrices;
        }
    }
}
