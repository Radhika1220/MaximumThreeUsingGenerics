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
            Console.WriteLine("Maximum string value is : " + obj.FindMaximumString("Apple","Banana","Peach"));
           
            Console.ReadLine();
        }
    }
}
