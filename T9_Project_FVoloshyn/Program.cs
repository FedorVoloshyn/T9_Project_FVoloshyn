using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_Project_FVoloshyn
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath =  @"F:\1.txt";
            string writePath = @"F:\2.txt";
            int numberOfStings;
            List<string> textFromFile = new List<string>();
            
            // Read file
            using (StreamReader sr = new StreamReader(readPath, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textFromFile.Add(line);
                }
            }
            numberOfStings = int.Parse(textFromFile[0]);
            //====================================================

            // Translate to T9
            List<string> t9EncodedText = new List<string>();
            T9Engine t9engine = new T9Engine();
            for(int i = 1; i < numberOfStings + 1; i++)
            {
                t9EncodedText.Add(t9engine.TextToNumber(textFromFile[i]));
            }
            //====================================================

            // Show result
            Console.WriteLine("Input\tOutput");
            Console.WriteLine(textFromFile[0]);
            for (int i = 0; i < numberOfStings; i++)
            {
                Console.WriteLine(textFromFile[i+1] + "\tCase #{0}: " + t9EncodedText[i], i+1);
            }
            //====================================================

            // Write file
            using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
            {
                foreach (var line in t9EncodedText)
                {
                    sw.WriteLine(line);
                }
            }
            //====================================================

            Console.ReadKey();
        }
    }
}
