using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            molecule.CountElements();

            return "Molar mass of " + formula + ": " + M + " g/mol";
        }
    }

    /**
     * Class containing one or more elements together with their count 
     */
    class ElementGroup
    {
        private int count;
        private ElementGroup[] content = null; //Stores array of element group objects in case this object stores an element group (in brackets)
        private string element = null; //Stores single element (as string) in case this object stores just a single element

        /**
         * Constructor - takes the formula and count of it and saves it to attributes
         * Formula is loaded into array as separate element groups (Fe, Na2 or (SO4)2)
         */
        public ElementGroup(string content, int count, bool containsElementGroup)
        {
            this.count = count;
            if (containsElementGroup)
            {
                //Split content variable (for example "(Co(CN)6)") into array of shorter strings ({"Co",1},{"CN",6})

                //If we got element group in brackets as content, we will skip the opening bracket, so we don't just return the whole group again
                if (content[0] == '(' )
                {
                    //Removing the brackets
                    content = content.Substring(1, content.Length - 2);
                }
                List<ElementGroup> currentElements = new List<ElementGroup>();
                int i = 0;
                while (i < content.Length)
                {
                    currentElements.Add(ReadElementGroup(content, i, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789()", "ABCDEFGHIJKLMNOPQRSTUVWXYZ()", out i));
                }

                this.content = currentElements.ToArray();
            }
            else
            {
                //Content is a single element
                this.element = content;
            }
        }

        /**
         * Method taking a whole formula, starting index and characters terminating end of element abbreviation or it's count
         * Returns the first loaded element group as object and index, where in the formula it ended as out parameter
         */
        private ElementGroup ReadElementGroup(string content, int startIndex, string contentTerminatingChars, string countTerminatingChars, out int endIndex)
        {
            int index = startIndex;
            int bracketsLevel = 0;
            string resultContent = "";
            string resultCount = "";

            do
            {
                resultContent += content[index];
                if (content[index] == '(') { bracketsLevel++; }
                if (content[index] == ')') { bracketsLevel--; }
                index++;
            } while (index < content.Length && (!contentTerminatingChars.Contains(content[index].ToString()) || (bracketsLevel > 0)));

            while (index < content.Length && (!countTerminatingChars.Contains(content[index].ToString())))
            {
                resultCount += content[index];
                index++;
            }
            if (resultCount.Length == 0) { resultCount = "1"; }

            bool containsGroup = false;
            if (resultContent.Contains("("))
            {
                //Resulting object contains element group, not a single element
                containsGroup = true;
            }
            endIndex = index;
            ElementGroup result = new ElementGroup(resultContent, Convert.ToInt32(resultCount), containsGroup);
            return result;
        }

        /**
         * Method going through the molecule tree and counting separated atoms by multiplying the numbers behind brackets
         * For example: [{"C",1},{[{"S",2},{"O",3}],2},{{["H",2},{"O",1}],5}] --> [{"C",1},{"S",4},{"O",6},{"H",10},{"O",5}]
         */
        internal void CountElements()
        {
            throw new NotImplementedException();
            //TODO
        }
    }
}
