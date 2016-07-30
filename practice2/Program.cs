using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*  Given an input string, reverse the string word by word.
*For example,
*Given s = "the sky is blue",
*return "blue is sky the". 
*
*/

namespace practice2
{
    class Program
    {
        public String ReverseWrods(String s)
        {
            String[] splitsR = s.Split(' ');
            StringBuilder result = new StringBuilder();
            
            for(int i = splitsR.Length -1; i >= 0; i--)
            {
                String temp = splitsR[i];

                if (temp.Length > 0)
                {
                    result.Append(splitsR[i]);
                    result.Append(' ');
                }
            }

            if (result.Length > 0)
                return result.ToString().Substring(0, result.Length-1);
            else
                return "";
         
        }
        
    }
}
