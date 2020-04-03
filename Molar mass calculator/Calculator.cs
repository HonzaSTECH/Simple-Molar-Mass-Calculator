using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace Molar_mass_calculator
{
    static class Calculator
    {
        public static string CalculateM(string formula)
        {
            double M = 0;

            try
            {
                //Load the formula into ElementGroup object
                ElementGroup molecule = new ElementGroup(formula, 1, true);

                //Disassemble the formula in the ElementGroup object to single elements
                Dictionary<string, int> elementsTable = molecule.CountElements();

                //Add the molar masses of all the atoms together
                M = AddMolarMasses(elementsTable);
            }
            catch (InvalidInputException e)
            {
                return e.Message + "\nPlease, check the Help menu for rules about writing formulas.";
            }
            catch (Exception e)
            {
                return "An unexpected exception occured.\nThis shouldn't be happening.\nCan you please submit a bug report via the Feedback menu (accessible via the help button).\nPlease, don't forget to include the formula you entered in your report.\n\nException details: " + e.ToString();
                //return "An exception occured.\nThis is most likely caused by invalid input.\nPlease, check the Help menu for rules about writing formulas and if this problem persist, submit a bug report via the Feedback menu.\nPlease, include the following informationg in your report. Thanks.\n\nAn exception occured while calculating molar mass of " + formula + ": " + e.ToString();
            }

            return "Molar mass of " + formula + ": " + M + " g/mol";
        }

        private static double AddMolarMasses(Dictionary<string, int> elementsTable)
        {
            var rSet = Elements.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            double result = 0;

            foreach (KeyValuePair<string, int> pair in elementsTable)
            {
                string singleElementMass = rSet.GetString(pair.Key);
                if (singleElementMass == null)
                {
                    throw new InvalidInputException("Unknown element: " + pair.Key);
                }
                Double mass = Double.Parse(singleElementMass, CultureInfo.InvariantCulture);
                result += mass * pair.Value;
            }

            return result;
        }
    }
}
