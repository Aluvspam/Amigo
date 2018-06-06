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
        public List<Engineer> RandomSelectEngineers()//metoda aceasta imi va amesteca lista interna de ingineri
        {
            List<Engineer> shuffledEngineers = new List<Engineer>();
            shuffledEngineers = allEngineers;
            int n = shuffledEngineers.Count;
            for (int i = 0; i < n; i++)
            {
                int random = i + rnd1.Next(n - i);
                // partea de jos e o schimbare ca la Bubble = se produce o inversare de la inginerul gasit in random cu inginerul aflat la index-ul i
                var temp = shuffledEngineers[random];
                shuffledEngineers[random] = shuffledEngineers[i];
                shuffledEngineers[i] = temp;
            }
            return shuffledEngineers;
        }
        #region METHODS TO ADD SHIFTS TO ENGINEERS
        public List<Engineer> AddShifts()//by using modulo we will set the even numbers to FirstShift and odd numbers to SecondShift
        {
            List<Engineer> engineersShift = new List<Engineer>();
            engineersShift = RandomSelectEngineers();//we will call again the RandomSelectEngineers(), we will run it again and the result will be added to engineersShift
            for (int i = 0; i < engineersShift.Count; i++)
            {

                if (i % 2 == 0)
                {
                    engineersShift[i] = SupportDay.FirstShift;//daca e par indexul de inginer = vine de dimineata 
                }
                else
                {
                    engineersShift[i].Shift = SupportDay.SecondShift;//daca e impar indexul de inginer = vine de dupa masa

                }
            }
            return engineersShift;
        }
        #endregion
        #endregion
    }
}
