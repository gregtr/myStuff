using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpQuickReference.src
{
    class XMLReader
    {
        //http://csharp.net-tutorials.com/xml/working-with-the-xmlnode-class/
        //http://csharp.net-tutorials.com/xml/reading-xml-with-the-xmlreader-class/
        public static void loadFileDummy()
        {
            XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
                
                /*
                    XMLDocument - is more memory consuming and possibly a bit slower than xmlReader approach
                 * 
                 * XMLDocument - reads entire xml content into memory - then we can navigate it as we please or even XPath query 
                 * 
                 * XMLReader - one content at a time 
                 
                 
                 */
                
                }
            }
            Console.ReadKey();
        }

        public static void loadFileDummyXmlDocument()
        {
            // require less code - due to the fact we're not doing stuff manually

            //(http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml) - gesmes:Envelope - root element

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            foreach(XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes) {
                console.WriteLine(xmlNode.Attributes["currency"].Value + ": " + xmlNode.Attributes["rate"].Value);
            }
        }

        public static void readNodes()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<user name=\"John Doe\">A user node</user>");
            Console.WriteLine(xmlDoc.documentElement.Name);
            // XmlDocument.documentElement.<propertyName>
            // <node property=proeprtyString></node>
            // return -> propertyString

            // XmlDocument.documentElement.InnerText
            // <node>Text</node>
            // return Text

            // 
            //
            //
        }

    }
}
