using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace cSharp_Features
{
    class Read_XML
    {
        void readXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("c:\\temp.xml");
            
        }
    }
}
