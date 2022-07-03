using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_And_Instance
{
    internal class Program
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public static void method(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine("start={0}",start);
                start = start + 2;
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
           int sum= obj.add(1, 2);
            Console.WriteLine("sum ={0}",sum);
            Program.method(20);
        }
    }
}
