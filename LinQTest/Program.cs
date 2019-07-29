using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinQTest
{
    class Program
    {
        struct Pet
        {
            public int RFID;
            public string name;
        }

        public static void runCode()
        {

            express();
        }
        public static void express()
        {
            List<Pet> Pets = new List<Pet> { new Pet { RFID = 0, name = "PUG"},
                                             new Pet { RFID = 1, name = "Maltese"},
                                             new Pet { RFID = 2, name = "Poodle"} };
            var petLookUp = Pets.ToDictionary(pet => pet.RFID);

            foreach(KeyValuePair<int,Pet> p in petLookUp)
            {
                Console.WriteLine(p.Key + " " + p.Value.name);
            }
        }

        public static IEnumerable<XElement> FindAllElementsWithAttribute(XElement documentRoot, 
                                                                         string elementName,
                                                                         string attributeName, 
                                                                         string value)
        {
            return from el in documentRoot.Elements(elementName)
                   where (string)el.Element(attributeName) == value
                   select el;
        }
    }
}
