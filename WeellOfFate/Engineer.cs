using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Engineer: Employee
    {
        public Engineer() : base()
        {

        }
        public Engineer(string name, int id, string role): base()
        {
            Name = name;
            Id = id;
            Role = role;
        }
    }
}
