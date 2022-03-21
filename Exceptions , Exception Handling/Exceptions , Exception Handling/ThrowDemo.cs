using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions___Exception_Handling
{
    internal class ThrowDemo
    {
        static void Main()
        {
            Console.Write("Ënter 1st number:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ënter 2nd number:");
            int y = int.Parse(Console.ReadLine());
            if(y%2>0)
            {

                throw new ApplicationException("Division should not be a Odd Number.");
                
            }
            int z = x / y;
            Console.WriteLine("The result is:" + z);
            Console.WriteLine("Ënd of the program");
            Console.WriteLine("--------------------------------------");
        }
    }
}
