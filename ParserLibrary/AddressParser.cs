using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParserLibrary
{
    public class AddressParser
    {
        public static string[] convertFileContent(ArrayList input)
        {
            string[] result = new string[input.Count];

            // ToDo: Konvertierung der eingehenden ArrayList in das gewünschte Ausgabeformat mit Hilfe regulärer Ausdrücke
            //    Vorname Nachname|Straße Hausnr.|PLZ|Ort|Land
            // => Nachname, Vorname, Straße, Hausnr., Land, PLZ, Ort
            for (int i = 0; i < input.Count; i++)
            {
                string[] entry = Regex.Split(input[i].ToString(), "^(.*)\\s(.*)\\|(.*)\\s(.*)\\|(.*)\\|(.*)\\|(.*)$");
                entry = entry.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                result[i] = $"{entry[1]}, {entry[0]}, {entry[2]}, {entry[3]}, {entry[6]}, {entry[4]}, {entry[5]}";
            }
            
            return result;
        }
    }
}
