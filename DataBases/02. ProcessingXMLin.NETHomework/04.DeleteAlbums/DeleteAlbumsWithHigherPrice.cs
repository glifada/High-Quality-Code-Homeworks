using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04.DeleteAlbums
{
    class DeleteAlbumsWithHigherPrice
    {
        static void Main(string[] args)
        {
            //Load Xml root element
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01.Catalogue.xml");
            XmlElement root = xmlDoc.DocumentElement;

            DeleteAlbumsWithPrice(root, 20.0);
            xmlDoc.Save("../../newCatalogue.xml");
            Console.WriteLine("Please see the new catalogue at ../../newCatalogue.xml!");
        }

        private static void DeleteAlbumsWithPrice(XmlElement root, double price)
        {
            foreach (XmlNode album in root.SelectNodes("album"))
            {
                double albumPrice = double.Parse(album["price"].InnerText);
                if (albumPrice > price)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}
