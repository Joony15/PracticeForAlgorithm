using System;


/*
 * LeetCode 
 * 
 *Validate if a given string is numeric.
 *Some examples:
 *"0" => true
 *" 0.1 " => true
 *"abc" => false
 *"1 a" => false
 *"2e10" => true
 * 
 */



namespace practice3
{
    class ValidNumber
    {
        public bool IsNumber(string s)
        {
            int start = 0;
            int end = s.Length;
            bool isNums = false;

            //check out leading char
            while (start < end && s[start] == ' ') start++;
            if (start < end && s[start] == '+' || s[start] == '-') start++;
            //check all is numeric
            if (start < end && Char.IsDigit(s[start]) == true)
            {
                start++;
                isNums = true;
            }
            //check for '.'
            if (start < end && s[start] == '.')
            {
                start++;
                while (start < end && Char.IsDigit(s[start]))
                {
                    start++;
                    isNums = true;
                }

            }
            //checl for 'e'
            if (isNums && start < end && s[start] == 'e')
            {
                start++;
                isNums = false;
                if (start < end && s[start] == '+' || s[start] == '-') { start++; }
                while (start < end && char.IsDigit(s[start]))
                {
                    start++;
                    isNums = true;
                }
            }
            while (start < end && s[start] == ' ') { start++; }
                    
            return isNums && start == end ;
        }
        
    }
}
