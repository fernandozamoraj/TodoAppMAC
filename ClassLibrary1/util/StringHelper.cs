using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.util
{
    public class StringHelper
    {
        private string _Name;

        public string Name
        {
            get
            {
                return _Name.ToUpperMario();
            }
            set
            {
                _Name = value;
            }
        }

        public StringHelper()
        {
            _Name = string.Empty;
        }

        public string[] CapitalizeAndSplit(string target, char delimiter)
        {
            string[] tokens = target.Split(delimiter);

            for(var i=0;i<tokens.Length;i++){
                tokens[i] =  tokens[i].ToUpper()[0] + tokens[i].Substring(1);
            }

            return tokens;
        }
    }
}
