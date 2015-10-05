using System;
using System.Xml.Xsl;

namespace _14.XslTransformToCatalogue
{
    class XslTransformToCatalogue
    {
        static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalogue.xsl");
            xslt.Transform("../../../01.Catalogue.xml", "../../catalogue.html");
        }
    }
}
