using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given an array of integers, find two numbers such that they add up to a specific target number.
The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. 
Please note that your returned answers (both index1 and index2) are not zero-based.
You may assume that each input would have exactly one solution
*/

namespace PracriceThing
{
    class Program
    {
        public int[] GetTwoSum(int[] n, int t)
        {
            int[] addNumber = new int[] {0, 0};

            for(int i = 0; i < n.Length; i++)
            {
                for(int j = i+1; j < n.Length; j++)
                {
                    if ((n[i] + n[j]) == t) {
                        addNumber[0] = i;
                        addNumber[1] = j;
                    }
                }
            }
            
                
            return addNumber;
        }
              
    }
}
