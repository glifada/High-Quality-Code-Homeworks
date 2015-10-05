using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace _16.CatalogueXSDSchema
{
    class CatalogueXSDSchema
    {
        static void Main(string[] args)
        {
            // Load xsd schema
            string xsdPath = "../../CatalogueSchema.xsd";
            XmlSchemaSet xsdSchema = LoadXsdFile(xsdPath);

            //Validate valid Xml file
            string validXmlPath = "../../../01.Catalogue.xml";
            XDocument validXmlDoc = LoadXmlFile(validXmlPath);
            Console.WriteLine("Validating valid xml document!");
            ValidateXmlFile(validXmlDoc, xsdSchema);

            Console.WriteLine();

            //Validate invalid Xml file
            string invalidXmlPath = "../../invalidCatalogue.xml";
            XDocument invalidXmlDoc = LoadXmlFile(invalidXmlPath);
            Console.WriteLine("Validating invalid xml document!");
            ValidateXmlFile(invalidXmlDoc, xsdSchema);
        }

        private static XmlSchemaSet LoadXsdFile(string xsdPath)
        {
            XmlSchemaSet xsdSchema = new XmlSchemaSet();
            xsdSchema.Add(string.Empty, xsdPath);

            return xsdSchema;
        }


        private static XDocument LoadXmlFile(string xmlPath)
        {
            XDocument xmlDoc = XDocument.Load(xmlPath);

            return xmlDoc;
        }

        private static void ValidateXmlFile(XDocument xmlDoc, XmlSchemaSet xsdSchema)
        {
            bool errors = false;
            xmlDoc.Validate(xsdSchema, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            Console.WriteLine("Document {0}", errors ? "did not validate!" : "validated!");
        }
    }
}
