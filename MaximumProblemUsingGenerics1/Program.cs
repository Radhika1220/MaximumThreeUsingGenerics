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
            Console.WriteLine("Maximum value is : " + obj.FindMaximumFloat(70.2f, 45.3f, 12.5f));
           
            Console.ReadLine();
        }
    }
}
