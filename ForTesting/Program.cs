using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeellOfFate;

namespace ForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //sa facem lista de 10 ingineri

             List<Engineer>  initialListOfEngineers = new List<Engineer>() { new Engineer("Andrei", 00, "Engineers"), new Engineer("Dragos", 01, "Inginer"),
            new Engineer("Elena", 02, "Inginer"), new Engineer("Ion", 03, "Inginer"), new Engineer("Cristi", 04, "Inginer"), new Engineer("Ene", 05, "Inginer"),
             new Engineer("Cosmin", 06, "Inginer"), new Engineer("Andreea", 07, "Inginer"), new Engineer("Claudiu", 08, "Inginer"), new Engineer("Eduard", 09, "Inginer")
            };
            Console.WriteLine("Lista initiala de ingineri");
            foreach (var item in initialListOfEngineers)
            {
                Console.WriteLine("Nume: {0}, id: {1}, rol: {2}.", item.Name, item.Id, item.Role);
            }
            //TESTAM BUSINESS RULES 

            BusinessRules myWeel = new BusinessRules(initialListOfEngineers);
           BAU b = new BAU(initialListOfEngineers);
            //  myWeel.Show1WeekofWork();
            myWeel.Show2WeeksOfWork();
          
            Console.ReadKey();
        }
       

        
    }
}
