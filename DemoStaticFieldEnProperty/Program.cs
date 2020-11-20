using System;

namespace DemoStaticFieldEnProperty
{
    class Student
    {
        private string _naam;
        private static int _aantal;
        public Student(string naam)
        {
            _naam = naam;
            _aantal++;
        }
        public static int Aantal{ get{ return _aantal; } }//static: op klasse niveau
        public string Naam { get { return _naam; } }//niet-static: op instantie/object niveau
        public static int Bereken()
        {
            //this.Naam lukt niet
            return _aantal * 1000; //lukt wel , static field
        }
        public int BerekenNietStatic()
        {
            return this._naam.Length;
        
        }
    }
    class Program
    {
        static void Main()
        {
          
            Console.WriteLine("Aantal studentobjecten aangemaakt:" + Student.Aantal);
            Student student1 = new Student("Jos");
            Student student2 = new Student("Jan");
            Console.WriteLine("Aantal studentobjecten aangemaakt:" + Student.Aantal);
            Console.WriteLine("Naam van eerste student: " + student1.Naam);
            Console.WriteLine("Naam van tweede student: " + student2.Naam);
            Console.WriteLine("Bereken static methode resultaat:" + Student.Bereken());
            Console.WriteLine("Bereken niet-static methode resultaat:" + student1.BerekenNietStatic());
        }
    }
}
