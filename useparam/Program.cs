using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useparams
{
    class sum
    {
        public int add(params int[] list)
        {
            int sum = 0;
            foreach(int x in list)
            {
                sum += x;
            }
            return sum;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            sum s1 = new sum();
            Console.WriteLine(s1.add(90, 30));
            Console.WriteLine(s1.add(65,78,87));
            Console.WriteLine(s1.add(90, 30,100,200));
            Console.ReadLine();

        }
    }
}
