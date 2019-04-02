using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDelegate
{
    class Program
    {
        delegate int Mydelegate(int a, int b);
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {

            Mydelegate callback;
            callback = new Mydelegate(Plus);
            Console.WriteLine(callback(3, 5));
            callback = new Mydelegate(Minus);
            Console.WriteLine(callback(7, 3));
        }
    }
}
