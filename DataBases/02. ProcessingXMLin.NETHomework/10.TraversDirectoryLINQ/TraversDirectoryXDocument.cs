using System;
using System.Linq;
using System.Xml.Linq;

namespace _10.TraversDirectoryXDocument
{
    class TraversDirectoryXDocument
    {
        private const string pathDirectory = "../../../../ProcessingXMLin.NETHomework";
        static void Main(string[] args)
        {
            string filePathToWrite = "../../directory.xml";
            CreateXmlFile(filePathToWrite, pathDirectory);
        }

        private static void CreateXmlFile(string filePathToWrite, string pathDirectory)
        {
            XDocument doc = new XDocument();
            XElement rootElement = new XElement("root", new XAttribute("path", pathDirectory));

            TraverseDirectories(pathDirectory, rootElement);
            TraverseFiles(pathDirectory, rootElement);
            doc.Add(rootElement);
            doc.Save(filePathToWrite);
        }

        private static void TraverseDirectories(string pathDirectory, XElement rootElement)
        {
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pathDirectory);
            System.IO.DirectoryInfo[] dirs = directory.GetDirectories();

            foreach (var dir in dirs)
            {
                XElement dirElement = new XElement("dir", new XAttribute("name", dir.Name));
                if (dir.GetDirectories().Any())
                {
                    TraverseDirectories(dir.FullName, dirElement);
                }
                TraverseFiles(dir.FullName, dirElement);
                rootElement.Add(dirElement);
            }
        }

        private static void TraverseFiles(string pathDirectory, XElement rootElement)
        {
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pathDirectory);
            System.IO.FileInfo[] files = directory.GetFiles();

            foreach (var file in files)
            {
                XElement fileElement = new XElement("file", new XAttribute("name", file.Name));
                rootElement.Add(fileElement);
            }
        }
    }
}
