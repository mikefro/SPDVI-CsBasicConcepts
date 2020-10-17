using ForEachListApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace foreachListApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var personaList = new List<PersonModel>();

            personaList.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            personaList.Add(new PersonModel { FirstName = "Bill", LastName = "McCoy" });
            personaList.Add(new PersonModel { FirstName = "Mary", LastName = "Jones" });
            personaList.Add(new PersonModel { FirstName = "Sue", LastName = "Smith" });


            var alumnes = new List<string>() { "John", "Mary", "Sue", "Greg", "Yolanda",
             "Jose", "Bill", "Daniel" };

            foreach (var name in alumnes)
                Console.WriteLine("Hello " + name);

            Console.WriteLine("Press any key to continue.....\n\n");
            Console.ReadKey();
            Console.WriteLine("List of person from a object list\n");

            foreach (PersonModel persona in personaList)
                Console.WriteLine($"Hello  {persona.FirstName } {persona.LastName }");

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();




        }
    }
}
