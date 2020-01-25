using ParserLibrary;
using System;
using System.Collections;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input.txt";
            string outputFile = "output.txt";

            //ToDo: Einlesen der Datei sowie Aufruf der Konvertierungs-Methode und Ausgabe der Ergebnisse
            ArrayList input = new ArrayList();

            using (StreamReader reader = new StreamReader(inputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    input.Add(line);
                }
            }

            string[] output = AddressParser.convertFileContent(input);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                for (int i = 0; i < output.Length; i++)
                {
                    writer.WriteLine(output[i]);
                }
            }

            Console.WriteLine("Done.");
            Console.Read();
        }
    }
}
