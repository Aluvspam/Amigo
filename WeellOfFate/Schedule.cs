using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Schedule//this will determine the work flow for 1 day/1 week (5 days) of shifts for engineers
    {
        #region fields
        WorkDay[] weekOfWork = new WorkDay[5]; // a work week has 5 days
        #endregion
        #region properties
        public WorkDay[] WeekOfWork { get { return weekOfWork; } set { weekOfWork = value; } }
        #endregion
        #region methods
        public void GetSchedule(List<Engineer> listOfEngineers)//takes a list of engineers and adds them to our array of WeekOfWork
        {
            for (int i = 0; i < weekOfWork.Length; i++)//e ok si asa pentru ca o saptamana mereu va avea 10 ingineri, nu conteaza ca ei ar putea fi mai multi de 10 intr-un BAU pentru ca ei oricum sunt amestecati la inceput si exista posiblitatea ca cei de la indexul 10 sa fie selectati, e mai hardcodat dar e ok
            {
                switch (i)
                {
                    case 0:
                        WeekOfWork[i] = new WorkDay(listOfEngineers[0], listOfEngineers[1]);
                        break;
                    case 1:
                        WeekOfWork[i] = new WorkDay(listOfEngineers[2], listOfEngineers[3]);
                        break;
                    case 2:
                        WeekOfWork[i] = new WorkDay(listOfEngineers[4], listOfEngineers[5]);
                        break;
                    case 3:
                        WeekOfWork[i] = new WorkDay(listOfEngineers[6], listOfEngineers[7]);
                        break;
                    case 4:
                        WeekOfWork[i] = new WorkDay(listOfEngineers[8], listOfEngineers[9]);
                        break;
                    default:
                        Console.WriteLine("Error. Please verify...");
                        break;
                }
            }
        }
        #endregion
    }
}
