using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02.ExtractAllDifferentArtists
{
    class ExtractAllDifferentArtists
    {
        static void Main(string[] args)
        {
            XmlNodeList albums = GetAllAlbums();

            //Print unique artists
            HashSet<string> artists = GetAllArtists(albums);
            Console.WriteLine("Artists: {0}", string.Join(", ", artists));

            //Print the number of albums for each artist
            Dictionary<string, int> albumsPerArtist = GetNumberOfAlbumsPerArtist(albums);
            foreach (var artist in albumsPerArtist)
            {
                Console.WriteLine("{0} --> {1} albums", artist.Key, artist.Value);
            }
        }
        private static XmlNodeList GetAllAlbums()
        {
            //Load XML root element
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01.Catalogue.xml");
            XmlElement rootNode = doc.DocumentElement;

            XmlNodeList albums = rootNode.GetElementsByTagName("album");

            return albums;
        }

        private static HashSet<string> GetAllArtists(XmlNodeList albums)
        {
            HashSet<string> artists = new HashSet<string>();

            foreach (XmlNode album in albums)
            {
                artists.Add(album["artist"].InnerText);
            }

            return artists;
        }

        private static Dictionary<string, int> GetNumberOfAlbumsPerArtist(XmlNodeList albums)
        {
            Dictionary<string, int> albumsPerArtist = new Dictionary<string, int>();

            foreach (XmlNode album in albums)
            {
                string artist = album["artist"].InnerText;

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