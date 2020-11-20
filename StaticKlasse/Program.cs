using System;
using System.Text;

namespace StaticKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            FileUtils.BestandsLocatie =   @"C:\TekstBestanden\Test1\";

            Console.WriteLine("Geef de tekst om op te slaan:");
            StringBuilder inhoud = new StringBuilder(Console.ReadLine());
            
            FileUtils.SchrijfTextBestand("TekstVanConsole.txt", inhoud);

            Console.WriteLine("Lees tekst uit bestand:");
            Console.WriteLine(FileUtils.LeesTekstBestand("TekstVanConsole.txt"));
          
        }
    }
}
