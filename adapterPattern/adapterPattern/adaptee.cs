using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    class adaptee : english
    {
        private string wantDefinition = "have a desire to possess or do (something); wish for.";
        private string anyDefinition = "used to refer to one or some of a thing or number of things, no matter how much or many.";
        private string becauseDefinition = "for the reason that; since.";
        private string theseDefinition = "plural form of this";
        public string getDefinition(string word)
        {
            switch (word)
            {
                case "want": return wantDefinition;
                case "any": return anyDefinition;
                case "because": return becauseDefinition;
                case "these": return theseDefinition;
                default: return " ";

            }
        }
    }

        public interface english {
            string getDefinition(string word);
        }

    
}
