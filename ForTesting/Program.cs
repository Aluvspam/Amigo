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
            new Engineer("Elena", 02, "Inginer"), new Engineer("Ion", 03, "Inginer"), new Engineer("Cosmin", 04, "Inginer"), new Engineer("Ene", 05, "Inginer"),
             new Engineer("Cosmin", 06, "Inginer"), new Engineer("Andreea", 07, "Inginer"), new Engineer("Claudiu", 08, "Inginer"), new Engineer("Eduard", 09, "Inginer")
            };
            Console.WriteLine("Lista initiala de ingineri");
            foreach (var item in initialListOfEngineers)
            {
                Console.WriteLine("Nume: {0}, id: {1}, rol: {2}.", item.Name,item.Id,item.Role);
            }
            //sa-i amestecam acum random (cum cere proiectul)
            BAU firstBAU = new BAU(initialListOfEngineers);
            List<Engineer> shufleEngineers = firstBAU.RandomSelectEngineers();
            Console.WriteLine("Lista cu inginerii amestecati: ");
            foreach (var item in shufleEngineers)
            {
                Console.WriteLine("Nume: {0}, id: {1}, rol: {2}.", item.Name, item.Id, item.Role);
            }
            //acum le adaugam ture inginerilor amestecati
            List<Engineer> addingShiftToEngineers = firstBAU.AddShifts(shufleEngineers);
            Console.WriteLine("Inginerii si turele lor:");
            foreach (var item in addingShiftToEngineers)
            {
                Console.WriteLine("Nume: {0}, id: {1}, rol: {2}. vine: {3}", item.Name, item.Id, item.Role, item.Shift);
            }

          
            Console.ReadKey();
        }
       

        
    }
}
