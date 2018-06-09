using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class BusinessRules//I prefer a separate class because in the exercises it's mentioned that in the future the business rules can suffer changes.
    {
        #region fields
        static List<Engineer> myEngineers = new List<Engineer>();
        BAU myBAU = new BAU(myEngineers);
        static  WorkDay[] myWeekOfWork = new WorkDay[5];
        Schedule programul = new Schedule();
        #endregion
        #region constructor
        public BusinessRules(List<Engineer> list)
        {
            myEngineers = list;
        }
        #endregion

        public void Show1WeekofWork()//ASTA AR TREBUIE SA AIBA UN PARAMENTRU DE ARRAY DE ZILE DE MUNCA SI GATA... SI VERIFIC CU IF SI AIA E...
        {
            Console.WriteLine("In saptamana uratoare se vor prezenta in ture, in felul urmator: ");
            List<Engineer> listaAmestecata = myBAU.RandomSelectEngineers();
            List<Engineer> listaAmestecataCuTure = myBAU.AddShifts(listaAmestecata);
            myWeekOfWork = programul.GetSchedule(listaAmestecataCuTure);

            for (int i = 0; i < myWeekOfWork.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Ziua de Luni: ");
                        Console.WriteLine("Prima tura: {0} a doua tura: {1}", myWeekOfWork[0].FirstEngineer.Name, myWeekOfWork[1].SecondEngineer.Name);
                        break;
                    case 1:
                        Console.WriteLine("Ziua de Marti: ");
                        Console.WriteLine("Prima tura: {0} a doua tura: {1}", myWeekOfWork[2].FirstEngineer.Name, myWeekOfWork[3].SecondEngineer.Name);
                        break;
                    case 2:
                        Console.WriteLine("Ziua de Miercuri: ");
                        Console.WriteLine("Prima tura: {0} a doua tura: {1}", myWeekOfWork[4].FirstEngineer.Name, myWeekOfWork[5].SecondEngineer.Name);
                        break;
                    case 3:
                        Console.WriteLine("Ziua de Joi: ");
                        Console.WriteLine("Prima tura: {0} a doua tura: {1}", myWeekOfWork[6].FirstEngineer.Name, myWeekOfWork[7].SecondEngineer.Name);
                        break;
                    case 4:
                        Console.WriteLine("Ziua de Vineri: ");
                        Console.WriteLine("Prima tura: {0} a doua tura: {1}", myWeekOfWork[8].FirstEngineer.Name, myWeekOfWork[9].SecondEngineer.Name);
                        break;
                    default:
                        break;
                }
            }

            //TO DO: sa fac sa-ti arate pe 2 saptamana si sa veriffi daca inginerii de vineri, prima saptamana sa nu fie si in a doua saptamana luni


        }
    }
}
