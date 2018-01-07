using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterPattern
{
    class spanish
    {
        private string spanAny = "utilizado para referirse a una o algunas de una cosa o cantidad de cosas, sin importar cuánto o muchas.";
        private string spanThese = "forma plural de esto";
        private string spanWant = "tener un deseo de poseer o hacer (algo); desear.";
        private string spanBecause = "por la razón que; ya que.";
        public string getDefinition(string word)
        {
            switch (word)
            {
                case "any": return spanAny;
                case "these": return spanThese;
                case "want": return spanWant;
                case "because": return spanBecause;
                default: return " ";
            }
        }
    }
}

  
