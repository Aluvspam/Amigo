using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class BAU // Here I will build the implementation for the engineers team (in the example 10).
    {
        //TO DO: aici o sa avem legata cred, partea vizuala unde avem clasificati inginerii ce vor participa in ziua respectiva pe suport
        // ma gandesc aici sa adaug lista de ingineri
        #region fields
        List<Engineer> allEngineers = new List<Engineer>();//lista interna de ingineri BAU
        Random rnd1 = new Random();//asta sa fie random1 pentru inginerul din tura 1
        Random rnd2 = new Random();//asta sa fie random2 pentru inginerul din tura 2
        #endregion
        #region constructor
        public BAU()
        {

        }
        /// <summary>
        /// This constructor will initilze my list of engineers
        /// </summary>
        /// <param name="list"></param>
        public BAU(List<Engineer> list)// ma gandesc ca as avea nevoie de un constructor care sa imi ia ca parametru toti ingineri si sa imi puna in lista interna de ingineri din BAU - INTREBARE! Aici ce am facut e dependency injection??
        {
            allEngineers = list;
        }
        #endregion
        #region methods
        public List<Engineer> RandomSelectEngineers()//metoda asta sa-mi scoata cei doi ingineri random, pentru tura 1 si pentru tura 2 din zi 
        {
            List<Engineer> towEngineersForShift = new List<Engineer>();// my list of 2 engieers for the day shift (SupportDay)
            //TO DO!
            return towEngineersForShift;
        }
        #endregion
    }
}
