using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_even_number_by_using_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i = 20; i <=100; i++)
                if(i % 2 == 0)
                    Console.WriteLine(i);
            Console.ReadLine();
            
        }
    }
}
