using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Manager: Employee// I don't think that the Manager has a real role in this exercise
    {
        #region constructor
        public Manager(string name, int no, string role) : base(name, no, role)
        {
            name = Name;
            no = Id;
            role = Role;
        }
        #endregion
        #region methods
        public static void InputData()
        {

        }
        #endregion
    }
}
