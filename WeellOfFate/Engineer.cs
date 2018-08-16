using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Engineer : Employee
    {
        #region constructors
        public Engineer() : base()
        {

        }
        /// <summary>
        /// Here we construct our engineers
        /// </summary>
        /// <param name="name">Engineer Name</param>
        /// <param name="id">Engineer Id</param>
        /// <param name="role">Engineer Role</param>
        public Engineer(string name, int id, string role) : base(name, id, role)
        {
            //Name = name;
            //Id = id;
            //Role = role;
        }
        #endregion
    }
}
