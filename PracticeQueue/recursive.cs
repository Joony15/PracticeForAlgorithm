using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQueue
{
    class Program
    {
        int partition(int n ,int m)
        {
            int count = 0, i;

            if (n < m)
            {
                m = n;
            }
            if (n == 0)
            {
                return 1;
            }

            for (i = 1; i <= m; i++)
            {
                count = count + partition(n - i, i);
            }
            return count;
        }
        static void Main()
        {
            int n, m;

            Program mProgram = new Program();

            Console.WriteLine("please input number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);
            Console.WriteLine("please input which");

            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m);
            Console.WriteLine(mProgram.partition(n,m));

            
        }
    }
  
}
