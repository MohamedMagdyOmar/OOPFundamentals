using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public class StringHandler
    {
        public string InsertSpaces (string source)
        {
            string result = string.Empty;

            if(!string.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if(Char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
                result = result.Trim();
            }

            return result;
        }
    }
}
