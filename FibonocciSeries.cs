using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class FibonocciSeries
    { 
    public void FindFibonocciSeriesNumber()
    {
        Console.Write("please enter how many fibonacci numbers we have to generate");
        int number = Convert.ToInt32(Console.ReadLine());
        int first = 0, second = 1;
        int result = 0;
        result = first + second;
        Console.WriteLine("first:{0} second:{1} result:{2}", first, second, result);
        Console.ReadLine();
    }
    
    }
}
s