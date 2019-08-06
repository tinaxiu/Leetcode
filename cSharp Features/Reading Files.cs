using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cSharp_Features
{
    class Reading_Files
    {
        void ReadWhole()
        {
            string text = File.ReadAllText(@"C:\Users\minyu\OneDrive\test.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines(@"C:\Users\minyu\OneDrive\test.txt");
        }

        void ReadLineByLine()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            StreamReader file =
                new StreamReader(@"c:\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            Console.ReadLine();
        }
    }
}
