using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите первое число: "); 
                int n = Convert.ToInt32(Console.ReadLine()); 
                                                             
                int result;
                if (n > 123)
                    result = (n - 123) * 3; 
                else
                    result = Math.Abs(n - 123);
                Console.WriteLine(result);
            
        }
    }
}
    

