using System;
using System.Collections.Generic;

namespace Molar_mass_calculator
{
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
            //Check if the content isn't empty
            if (content.Length == 0)
            {
                throw new InvalidInputException("You didn't enter any formula.");
            }

            this.count = count;
            if (containsElementGroup)
            {
                //Split content variable (for example "(Co(CN)6)") into array of shorter strings ({"Co",1},{"CN",6})

                //If we got element group in brackets as content, we will skip the opening bracket, so we don't just return the whole group again
                if (content[0] == '(' && content[content.Length - 1] == ')')
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

            //Checking for balanced brackets
            if (bracketsLevel != 0)
            {
                throw new InvalidInputException("Unbalanced brackets.");
            }

            while (index < content.Length && (!countTerminatingChars.Contains(content[index].ToString())))
            {
                resultCount += content[index];
                index++;
            }
            if (resultCount.Length == 0) { resultCount = "1"; }
            try
            {
                int resultCountInt = Convert.ToInt32(resultCount);
            }
            catch (FormatException e) 
            {
                throw new InvalidInputException("Count of element or element group " + resultContent + " contains a non-number character.");
            }

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
         * Returns dictionary with elements as keys and their counts as values
         */
        internal Dictionary<string, int> CountElements()
        {
            this.MultiplyElements(this.count);  //this.count is always 1, because this method is called only from the object containing the whole molecule
            return this.ExtractElementDictionary();
        }

        /**
         * Method multiplying the count of single atoms in the formula by the numbers behind brackets (H2O)5 --> (H10,O5)1
         */
        private void MultiplyElements(int multiplier)
        {
            if (this.element != null)
            {
                this.count *= multiplier;
            }
            else
            {
                foreach (ElementGroup current in this.content)
                {
                    current.MultiplyElements(this.count * multiplier);
                }
                this.count = 1;
            }
        }

        /**
         * Method returning dictionary of elements with their counts in the whole molecule
         * If no dictionary is provided for writing as argument, an empty one will be created and sent further
         * That happens only in the object containing the whole molecule
         */
        private Dictionary<string, int> ExtractElementDictionary(Dictionary<string, int> result = null)
        {
            if (result == null)
            {
                result = new Dictionary<string, int>();
            }

            if (this.element != null)
            {
                //Append new element or add it's count to already existing key in the dictionary
                try
                {
                    //Element already exists in the dictionary
                    result[this.element] += this.count;
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    //Element doesn't exist in the dictionary yet
                    result.Add(this.element, this.count);
                }
            }
            else
            {
                //Iterate through all element groups stored in the array and do the same inside of them
                foreach (ElementGroup current in this.content)
                {
                    current.ExtractElementDictionary(result);
                }
            }
            return result;
        }
    }
}
