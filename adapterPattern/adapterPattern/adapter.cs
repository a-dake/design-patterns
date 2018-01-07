using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    class adapter : english
    {
        spanish span = new spanish();
        public string getDefinition(string word)
        {
            return span.getDefinition(word);
        }
    }


}
