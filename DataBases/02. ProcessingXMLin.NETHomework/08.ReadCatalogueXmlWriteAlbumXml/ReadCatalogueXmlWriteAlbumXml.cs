using System;
using System.Collections.Generic;
using System.Xml;

namespace _08.ReadCatalogueXmlWriteAlbumXml
{
    class ReadCatalogueXmlWriteAlbumXml
    {
        static void Main(string[] args)
        {
            string filePathToRead = "../../../01.Catalogue.xml";
            IDictionary<string, string> albums = ReadXmlFile(filePathToRead);

            string filePathToWrite = "../../album.xml";
            WriteXmlFile(filePathToWrite, albums);
        }

        private static IDictionary<string, string> ReadXmlFile(string filePathToRead)
        {
            IDictionary<string, string> albums = new Dictionary<string, string>();

            using (XmlReader reader = XmlReader.Create(filePathToRead))
            {
                string albumName = string.Empty;
                string albumArtist = string.Empty;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                    {
                        albumName = reader.ReadElementString();
                    }

                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "artist")
                    {
                        albumArtist = reader.ReadElementString();
                    }

                    if (!string.IsNullOrEmpty(albumName) && !string.IsNullOrEmpty(albumArtist))
                    {
                        albums[albumName] = albumArtist;
                    }
                }
            }

            return albums;
        }

        private static void WriteXmlFile(string filePathToWrite, IDictionary<string, string> albums)
        {
            // Settings
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(filePathToWrite, settings))
            {
                // Write in xml file
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                foreach (var album in albums)
                {
                    writer.WriteStartElement("album");

                    writer.WriteStartElement("name");
                    writer.WriteString(album.Key);
                    writer.WriteEndElement();

                    writer.WriteStartElement("artist");
                    writer.WriteString(album.Value);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
