using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NaNoWriMo
{
    class XMLManager
    {

        private XmlDocument xmlDoc;
        public XMLManager(string xmlString)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
        }

        public Dictionary<string,string> WordCountValues()
        {
            Dictionary<string, string> response = new Dictionary<string, string>();
            foreach (XmlNode item in xmlDoc.FirstChild.NextSibling)
            {
                response.Add(item.Name, item.FirstChild.Value);
            }
            return response;
        }

        public bool CheckErrorReturn()
        {
            return xmlDoc.FirstChild.NextSibling.FirstChild.Name != "error";
        }


    }
}
