using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProblemUsingGenerics1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximumAmongThree obj = new FindMaximumAmongThree();
            obj.FindMaximum(70, 35, 56);
            Console.ReadLine();
        }
    }
}
