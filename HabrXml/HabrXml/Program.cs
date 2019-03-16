using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Net;

namespace HabrXml
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var client = new WebClient())
            //{
            //    var items = new List<Item>();

            //    var xml = client.DownloadString("https://habr.com/ru/rss/interesting/");

            //    XmlDocument xmlDocument = new XmlDocument();
            //    xmlDocument.LoadXml(xml);

            //    foreach (XmlElement xelement in xmlDocument.GetElementsByTagName("item"))
            //    {
            //        XmlNode titleElement = null;
            //        XmlNode linkElement = null;
            //        XmlNode descriptionElement = null;
            //        XmlNode pubDateElement = null;
            //        foreach (XmlElement child in xelement)
            //        {
            //            if (child.Name == "title")
            //            {
            //                titleElement = child;
            //            }
            //            else if (child.Name == "link")
            //            {
            //                linkElement = child;
            //            }
            //            else if (child.Name == "description")
            //            {
            //                descriptionElement = child;
            //            }
            //            else if (child.Name == "pubDate")
            //            {
            //                pubDateElement = child;
            //            }
            //        }
            //        var item = new Item
            //        {
            //            Title = titleElement.InnerText,
            //            Link = linkElement.InnerText,
            //            Description = descriptionElement.InnerText,
            //            PubDate = pubDateElement.InnerText

            //        };
            //        items.Add(item);
            //    }
            //}






            XmlDocument xmlDocument = new XmlDocument();

            XmlElement rootStudentElement = xmlDocument.CreateElement("student");

            XmlElement firstNameElement = xmlDocument.CreateElement("firstName");
            firstNameElement.InnerText = "Иван";
            rootStudentElement.AppendChild(firstNameElement);

            XmlElement lastNameElement = xmlDocument.CreateElement("lastName");                
            lastNameElement.InnerText = "Иванов";
            rootStudentElement.AppendChild(lastNameElement);

            XmlElement ageElement = xmlDocument.CreateElement("age");
            ageElement.InnerText = "8";
            rootStudentElement.AppendChild(ageElement);

            XmlElement cityElement = xmlDocument.CreateElement("city");
            cityElement.InnerText = "Астана";
            rootStudentElement.AppendChild(cityElement);

            xmlDocument.AppendChild(rootStudentElement);

            xmlDocument.Save("data.xml");

            Console.ReadLine();
        }
    }
}
