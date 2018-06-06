using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Workflow//this class will determine the workflow on a day/week/2 weeks of shifts
    {
        //TO DO: trebuie sa-i mai bag implementare, si sa ma mai uit la proiectul ala geometry cum am facut segmentul din 2 puncte => ca si eu am 1 zi de lucru = formata din 2 ingineri... 
        static Engineer part1DayEng;//un inginer si prima parte a zilei
        static Engineer part2DayEng;//un inginer si a doua parte a zilei
        public static Engineer[] dayOfWork = new Engineer[2] { part1DayEng, part2DayEng };//o zi de munca are 2 ingineri
        public Workflow(Engineer part1Day, Engineer part2Day)//un constructor care imi costruieste ziua de munca din 2 ingineri
        {
            part1DayEng = part1Day;
            part2DayEng = part2Day;
        }
    }
}
