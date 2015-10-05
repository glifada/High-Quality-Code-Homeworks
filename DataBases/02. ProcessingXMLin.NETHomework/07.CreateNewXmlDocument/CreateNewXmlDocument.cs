using System;
using System.IO;
using System.Xml;

namespace _07.CreateNewXmlDocument
{
    class CreateNewXmlDocument
    {
        static void Main(string[] args)
        {
            string textFilePath = "../../person.txt";
            string textFileString = ReadTextFile(textFilePath);
            string[] textFileData = ConvertStringToStringArray(textFileString);

            string xmlFilePath = "../../persons.xml";
            WriteXmlDocument(xmlFilePath, textFileData);
        }

        private static string ReadTextFile(string textFilePath)
        {
            string textFileString = string.Empty;

            using (StreamReader reader = new StreamReader(textFilePath))
            {
                textFileString = reader.ReadToEnd();
            }

            return textFileString;
        }

        private static string[] ConvertStringToStringArray(string textFileString)
        {
            string[] textFileData = textFileString.Split('\n');

            return textFileData;
        }

        private static void WriteXmlDocument(string xmlFilePath, string[] textFileData)
        {
            // Settings
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(xmlFilePath, settings))
            {
                // Write in persons.xml
                writer.WriteStartDocument();
                writer.WriteStartElement("persons");
                writer.WriteStartElement("person");
                writer.WriteStartElement("name");
                writer.WriteString(textFileData[0]);
                writer.WriteEndElement();

                writer.WriteStartElement("address");
                writer.WriteString(textFileData[1]);
                writer.WriteEndElement();

                writer.WriteStartElement("phone");
                writer.WriteString(textFileData[2]);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
