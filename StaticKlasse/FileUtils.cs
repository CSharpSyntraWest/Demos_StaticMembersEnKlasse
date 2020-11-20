using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StaticKlasse
{
    public static class FileUtils
    {
        public static string BestandsLocatie { get; set; } = @"C:\TekstBestanden\";
        public static StringBuilder LeesTekstBestand(string naam)
        {
            string volledigeBestandsNaam = Path.Combine(BestandsLocatie, naam);

            if (!File.Exists(volledigeBestandsNaam)) throw new ArgumentException($"Kan bestand {volledigeBestandsNaam} niet vinden");
            return new StringBuilder(File.ReadAllText(volledigeBestandsNaam));

        }
        public static void SchrijfTextBestand(string naam,StringBuilder inhoud)
        {          
            string volledigeBestandsNaam = Path.Combine(BestandsLocatie, naam);
            if (!Directory.Exists(BestandsLocatie)) Directory.CreateDirectory(BestandsLocatie);
            File.WriteAllText(volledigeBestandsNaam, inhoud.ToString());
        }
    }
}
