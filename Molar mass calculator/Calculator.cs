using System;
using System.Collections.Generic;

namespace Molar_mass_calculator
{
    static class Calculator
    {
        public static string CalculateM(string formula)
        {
            double M = 0;

            //Load the formula into ElementGroup object
            ElementGroup molecule = new ElementGroup(formula, 1, true);

            //Disassemble the formula in the ElementGroup object to single elements
            Dictionary<string,int> elementsTable = molecule.CountElements();

            //Add the molar masses of all the atoms together
            M = AddMolarMasses(elementsTable);

            return "Molar mass of " + formula + ": " + M + " g/mol";
        }

        private static double AddMolarMasses(Dictionary<string, int> elementsTable)
        {
            throw new NotImplementedException();
        }
    }
}
