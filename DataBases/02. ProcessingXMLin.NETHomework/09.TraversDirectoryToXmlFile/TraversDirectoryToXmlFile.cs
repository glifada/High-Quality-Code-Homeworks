using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _09.TraversDirectoryToXmlFile
{
    class TraversDirectoryToXmlFile
    {
        private const string pathDirectory = "../../../../ProcessingXMLin.NETHomework";
        static void Main(string[] args)
        {
            string filePathToWrite = "../../directory.xml";
            CreateXmlFile(filePathToWrite, pathDirectory);
        }

        private static void CreateXmlFile(string filePathToWrite, string pathDirectory)
        {
            // Settings
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(filePathToWrite, settings))
            {
                // Write in xml file
                writer.WriteStartDocument();
                writer.WriteStartElement("root");
                writer.WriteAttributeString("path", pathDirectory);
                TraverseDirectories(pathDirectory, writer);
                TraverseFiles(pathDirectory, writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private static void TraverseDirectories(string pathDirectory, XmlWriter writer)
        {
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pathDirectory);
            System.IO.DirectoryInfo[] dirs = directory.GetDirectories();

            foreach (var dir in dirs)
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", dir.Name);
                if (dir.GetDirectories().Any())
                {
                    TraverseDirectories(dir.FullName, writer);
                }
                TraverseFiles(dir.FullName, writer);
                writer.WriteEndElement();
            }
        }

        private static void TraverseFiles(string pathDirectory, XmlWriter writer)
        {
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pathDirectory);
            System.IO.FileInfo[] files = directory.GetFiles();

            foreach (var file in files)
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteEndElement();
            }
        }
    }
}
