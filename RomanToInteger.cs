using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_practiceCodes
{
    internal class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            if (s != null && s.Length>0)
            {
                Dictionary<char, int> romanValues = new Dictionary<char, int>()
                {
                  {'I', 1},
                  {'V', 5},
                  {'X', 10},
                  {'L', 50},
                  {'C', 100},
                  {'D', 500},
                  {'M', 1000}
                };
                for (int i = 0;i<s.Length;i++)
                {
                    if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i+1]])
                    {
                        result = result - romanValues[s[i]];
                    }
                    else
                    {
                        result = result + romanValues[s[i]];
                    }
                }
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}

