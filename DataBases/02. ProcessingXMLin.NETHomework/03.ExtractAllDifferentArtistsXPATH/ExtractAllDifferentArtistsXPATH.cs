using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03.ExtractAllDifferentArtistsXPATH
{
    class ExtractAllDifferentArtistsXPATH
    {
        static void Main(string[] args)
        {
            XmlNodeList albums = GetAllAlbums();

            //Print all different artists
            var artists = GetAllArtists(albums);
            Console.WriteLine("All different artists: {0}", string.Join(", ", artists));

            //Print the number of albums for each artist
            Dictionary<string, int> albumsPerArtist = GetNumberOfAlbumsPerArtist(albums);
            foreach (var artist in albumsPerArtist)
            {
                Console.WriteLine("{0} --> {1} albums", artist.Key, artist.Value);
            }
        }

        private static XmlNodeList GetAllAlbums()
        {
            //Load XML document
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01.Catalogue.xml");

            string xPathQuery = "/catalogue/album";
            XmlNodeList albums = xmlDoc.SelectNodes(xPathQuery);

            return albums;
        }

        private static HashSet<string> GetAllArtists(XmlNodeList albums)
        {
            HashSet<string> artists = new HashSet<string>();

            foreach (XmlNode album in albums)
            {
                XmlNode artist = album.SelectSingleNode("artist");
                artists.Add(artist.InnerText);
            }

            return artists;
        }

        private static Dictionary<string, int> GetNumberOfAlbumsPerArtist(XmlNodeList albums)
        {
            Dictionary<string, int> albumsPerArtist = new Dictionary<string, int>();

            foreach (XmlNode album in albums)
            {
                string artist = album.SelectSingleNode("artist").InnerText;

                if (!albumsPerArtist.ContainsKey(artist))
                {
                    albumsPerArtist[artist] = 0;
                }

                albumsPerArtist[artist]++;
            }

            return albumsPerArtist;
        }
    }
}
