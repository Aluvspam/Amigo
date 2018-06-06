using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Schedule//this will determine the work flow for a day/1week/2weeks of shifts for engineers
    {
        //TO DO: trebuie sa-i mai bag implementare, si sa ma mai uit la proiectul ala geometry cum am facut segmentul din 2 puncte => ca si eu am 1 zi de lucru = formata din 2 ingineri... 
        static Engineer part1DayEng;//un inginer si prima parte a zilei
        static Engineer part2DayEng;//un inginer si a doua parte a zilei
        public static Engineer[] dayOfWork = new Engineer[2] { part1DayEng, part2DayEng };//o zi de munca are 2 ingineri
        public Schedule(Engineer part1Day, Engineer part2Day)//un constructor care imi costruieste ziua de munca din 2 ingineri
        {
            part1DayEng = part1Day;
            part2DayEng = part2Day;
        }
        static void BauShift()
        {

        }
        public virtual void GetSchedule()
        {

        }
    }
}
