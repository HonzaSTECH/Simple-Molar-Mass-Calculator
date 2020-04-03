using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molar_mass_calculator
{
    class InvalidInputException : Exception
    {
        public InvalidInputException(String message) : base(message){}
    }
}
