using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracriceThing
{
    class Program
    {

         void right_rotate(int[] arr, int s, int t)
        {
           int i, last;
           
           last = arr[t];
           for (i = t; i > s; i--){ 
               arr[i] = arr[i-1];}
           arr[s] = last;
        }
        void left_rotate(int[] arr, int s, int t)
        {
           int i, start;

           start = arr[s];
           for (i = s; i < t; i++)
               arr[i] = arr[i + 1];
           arr[t] = start;
        }
        void coustom_rotate(int []arr, int s, int t, int n)
        {
            int []numarr = new int[n];
            int i;

            for (i = 0; i < n; i++)
                numarr[i] = arr[t - i];
            for (i = t; i > s; i--)
                arr[i] = arr[i - n];
           for (i = 0; i < n; i++)
                arr[s + i] = numarr[n-1 - i];
        }
        static void Main(string[] args)
        {
            int[] arrPrac = {1,2,3,4,5,6,7,8};
            int n;
            Program mProgram = new Program();
            foreach(var item in arrPrac)
                Console.WriteLine("{0}",item);          
            mProgram.right_rotate(arrPrac, 2, 6);

            Console.WriteLine("=========after rotate");
            foreach(var item in arrPrac)
                Console.WriteLine("{0}",item);
            mProgram.left_rotate(arrPrac, 2, 6);

            Console.WriteLine("=============return if it is correctily acted");
            foreach(var item in arrPrac)
                Console.WriteLine("{0}",item);
            Console.Write("How many time do you want to return your array?");
            n = Convert.ToInt32(Console.ReadLine());
            mProgram.coustom_rotate(arrPrac, 2, 6,n);
            Console.WriteLine("===============it is adopted returning n times "  );
            foreach (var item in arrPrac)
                Console.Write("{0}",item);
                
        }
        
    }
}
