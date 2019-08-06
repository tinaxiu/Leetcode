using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinQTest
{
    class exersice
    {
        class Pet
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        class solution
        {
            void s1()
            {
                List<Pet> Pets = new List<Pet>
            {
                new Pet{ id = 0, name =  "PUG"},
                new Pet{id = 1, name = "Maltese" }
            };

                var dic = Pets.ToDictionary(pet => pet.id);
            }
        }
    }
}
