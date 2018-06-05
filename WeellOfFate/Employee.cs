using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Employee
    {
        #region fields
        string name;
        string role;
        int id;
        #endregion
        #region proprieties
        public string Name { get { return name; } set { name = value; } }
        public string Role { get { return role; } set { role = value; } }
        public int Id { get { return id; } set { id = value; } }
        #endregion
        #region constructors
        public Employee()//un constructor gol, pentru situatile in care am nevoie doar sa instantiez un obiect de tip Employee
        {

        }
        /// <summary>
        /// here we construct our employees
        /// </summary>
        /// <param name="N">Name of employee</param>
        /// <param name="ID">Id of employee</param>
        /// <param name="ROLE">Role of employee</param>
        public Employee(string N, int ID, string ROLE)
        {
            Name = N;
            Id = ID;
            Role = ROLE;
        }
        #endregion
    }
}
