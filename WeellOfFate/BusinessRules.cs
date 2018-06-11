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
        static BAU myBAU = new BAU(myEngineers);
        static WorkDay[] myWeekOfWork1 = new WorkDay[5];//first week
        Schedule programul1 = new Schedule();// first week calendar 

        static WorkDay[] myWeekOfWork2 = new WorkDay[5];//second week
        Schedule programul2 = new Schedule();// second week calendar 
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
            myWeekOfWork1 = programul1.GetSchedule(listaAmestecataCuTure);

            for (int i = 0; i < myWeekOfWork1.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Ziua de Luni: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[0].FirstEngineer.Name, myWeekOfWork1[0].FirstEngineer.Id, myWeekOfWork1[0].SecondEngineer.Name, myWeekOfWork1[0].SecondEngineer.Id);
                        break;
                    case 1:
                        Console.WriteLine("Ziua de Marti: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[1].FirstEngineer.Name, myWeekOfWork1[1].FirstEngineer.Id, myWeekOfWork1[1].SecondEngineer.Name, myWeekOfWork1[1].SecondEngineer.Id);
                        break;
                    case 2:
                        Console.WriteLine("Ziua de Miercuri: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[2].FirstEngineer.Name, myWeekOfWork1[2].FirstEngineer.Id, myWeekOfWork1[2].SecondEngineer.Name, myWeekOfWork1[2].SecondEngineer.Id);
                        break;
                    case 3:
                        Console.WriteLine("Ziua de Joi: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[3].FirstEngineer.Name, myWeekOfWork1[3].FirstEngineer.Id, myWeekOfWork1[3].SecondEngineer.Name, myWeekOfWork1[3].SecondEngineer.Id); ;
                        break;
                    case 4:
                        Console.WriteLine("Ziua de Vineri: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[4].FirstEngineer.Name, myWeekOfWork1[4].FirstEngineer.Id, myWeekOfWork1[4].SecondEngineer.Name, myWeekOfWork1[4].SecondEngineer.Id);
                        break;
                    default:
                        break;
                }
            }
        }
        public void Show2WeeksOfWork()//si sa verifice conditia ca ziua precedenta de vineri sa nu se sincronizeze cu cei din ziua de luni 
        {
            Console.WriteLine("In urmatoarele doua saptamani se vor prezenta in ture, in felul urmator: ");
            List<Engineer> lista1Amestecata = myBAU.RandomSelectEngineers();
            List<Engineer> lista1AmestecataCuTure = myBAU.AddShifts(lista1Amestecata);
            myWeekOfWork1 = programul1.GetSchedule(lista1AmestecataCuTure);

            for (int i = 0; i < myWeekOfWork1.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Ziua de Luni: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[0].FirstEngineer.Name, myWeekOfWork1[0].FirstEngineer.Id, myWeekOfWork1[0].SecondEngineer.Name, myWeekOfWork1[0].SecondEngineer.Id);
                        break;
                    case 1:
                        Console.WriteLine("Ziua de Marti: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[1].FirstEngineer.Name, myWeekOfWork1[1].FirstEngineer.Id, myWeekOfWork1[1].SecondEngineer.Name, myWeekOfWork1[1].SecondEngineer.Id);
                        break;
                    case 2:
                        Console.WriteLine("Ziua de Miercuri: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[2].FirstEngineer.Name, myWeekOfWork1[2].FirstEngineer.Id, myWeekOfWork1[2].SecondEngineer.Name, myWeekOfWork1[2].SecondEngineer.Id);
                        break;
                    case 3:
                        Console.WriteLine("Ziua de Joi: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[3].FirstEngineer.Name, myWeekOfWork1[3].FirstEngineer.Id, myWeekOfWork1[3].SecondEngineer.Name, myWeekOfWork1[3].SecondEngineer.Id); ;
                        break;
                    case 4:
                        Console.WriteLine("Ziua de Vineri: ");
                        Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork1[4].FirstEngineer.Name, myWeekOfWork1[4].FirstEngineer.Id, myWeekOfWork1[4].SecondEngineer.Name, myWeekOfWork1[4].SecondEngineer.Id);
                        break;
                    default:
                        break;
                }
            }
            //acum facem un  while ce ne verifica ultimul precedent cu primul 
            List<Engineer> lista2AmestecataCuTure = myBAU.AddShifts();//WE will pass again the random method
            myWeekOfWork2 = programul2.GetSchedule(lista2AmestecataCuTure);

            if((myWeekOfWork1[0].FirstEngineer.Id != myWeekOfWork2[4].FirstEngineer.Id) ||( myWeekOfWork1[0].SecondEngineer.Id != myWeekOfWork2[4].SecondEngineer.Id) ||( myWeekOfWork1[0].SecondEngineer.Id != myWeekOfWork2[4].FirstEngineer.Id) || (myWeekOfWork1[0].SecondEngineer.Id != myWeekOfWork2[4].SecondEngineer.Id))//verificam daca ultimi nu sunt egali cu primi sapt 2
            {
                for (int i = 0; i < myWeekOfWork2.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Ziua de Luni: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[0].FirstEngineer.Name, myWeekOfWork2[0].FirstEngineer.Id, myWeekOfWork2[0].SecondEngineer.Name, myWeekOfWork2[0].SecondEngineer.Id);
                            break;
                        case 1:
                            Console.WriteLine("Ziua de Marti: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[1].FirstEngineer.Name, myWeekOfWork2[1].FirstEngineer.Id, myWeekOfWork2[1].SecondEngineer.Name, myWeekOfWork2[1].SecondEngineer.Id);
                            break;
                        case 2:
                            Console.WriteLine("Ziua de Miercuri: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[2].FirstEngineer.Name, myWeekOfWork2[2].FirstEngineer.Id, myWeekOfWork2[2].SecondEngineer.Name, myWeekOfWork2[2].SecondEngineer.Id);
                            break;
                        case 3:
                            Console.WriteLine("Ziua de Joi: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[3].FirstEngineer.Name, myWeekOfWork2[3].FirstEngineer.Id, myWeekOfWork2[3].SecondEngineer.Name, myWeekOfWork2[3].SecondEngineer.Id); ;
                            break;
                        case 4:
                            Console.WriteLine("Ziua de Vineri: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[4].FirstEngineer.Name, myWeekOfWork2[4].FirstEngineer.Id, myWeekOfWork2[4].SecondEngineer.Name, myWeekOfWork2[4].SecondEngineer.Id);
                            break;
                        default:
                            break;
                    }
                }
            }
            else//mai rulam o data add shift 
            {
                lista2AmestecataCuTure = myBAU.AddShifts();
                for (int i = 0; i < myWeekOfWork2.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Ziua de Luni: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[0].FirstEngineer.Name, myWeekOfWork2[0].FirstEngineer.Id, myWeekOfWork2[0].SecondEngineer.Name, myWeekOfWork2[0].SecondEngineer.Id);
                            break;
                        case 1:
                            Console.WriteLine("Ziua de Marti: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[1].FirstEngineer.Name, myWeekOfWork2[1].FirstEngineer.Id, myWeekOfWork2[1].SecondEngineer.Name, myWeekOfWork2[1].SecondEngineer.Id);
                            break;
                        case 2:
                            Console.WriteLine("Ziua de Miercuri: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[2].FirstEngineer.Name, myWeekOfWork2[2].FirstEngineer.Id, myWeekOfWork2[2].SecondEngineer.Name, myWeekOfWork2[2].SecondEngineer.Id);
                            break;
                        case 3:
                            Console.WriteLine("Ziua de Joi: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[3].FirstEngineer.Name, myWeekOfWork2[3].FirstEngineer.Id, myWeekOfWork2[3].SecondEngineer.Name, myWeekOfWork2[3].SecondEngineer.Id); ;
                            break;
                        case 4:
                            Console.WriteLine("Ziua de Vineri: ");
                            Console.WriteLine("Prima tura: {0} ID: {1}, a doua tura: {2} ID: {3}", myWeekOfWork2[4].FirstEngineer.Name, myWeekOfWork2[4].FirstEngineer.Id, myWeekOfWork2[4].SecondEngineer.Name, myWeekOfWork2[4].SecondEngineer.Id);
                            break;
                        default:
                            break;
                    }
                }
            }
          
        }
    }
}
