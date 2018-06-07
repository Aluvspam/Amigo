using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class WorkDay //this class will help me construct a day of work (that has 2 shifts)
    {
        #region fields
        Engineer firstEngineer;
        Engineer secondEngineer;
        #endregion
        #region properties
        public Engineer FirstEngineer { get { return firstEngineer; } set { firstEngineer = value; } }
        public Engineer SecondEngineer { get { return secondEngineer; } set { secondEngineer = value; } }
        #endregion
        #region constructor
        public WorkDay(Engineer firstShift, Engineer secondShift)
        {
            FirstEngineer = firstShift;
            SecondEngineer = secondShift;
        }
        #endregion
    }
}
