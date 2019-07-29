using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class ReadFile
    {
        
        class Student
        {
            public string Name {get; set;}
            public int SSN { get; set; }
            public string City { get; set; }

            public Student(int ssn, string name, string city)
            {
                Name = name;
                SSN = ssn;
                City = city;
            }
    
        }
        public static string read(int select)
        {
            string str;
            Dictionary<int,Student> list = new Dictionary<int,Student>();
            StreamReader file = new StreamReader(@"test.txt");

            while ((str = file.ReadLine()) != null)
            {
                Student st= new Student(Int32.Parse(str.Split(',')[0]), str.Split(',')[1], str.Split(',')[2]);
                list.Add(st.SSN,st);               
            }

            if(list.ContainsKey(select))
            {
                return list[select].Name;
            }
            else
            {
                return "";
            }
        }
        
    }
}
