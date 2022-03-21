using System;

namespace Exceptions___Exception_Handling
{
    class Exceptions
    {
       static void Main()
       {
            Console.Write("Ënter 1st number:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ënter 2nd number:");
            int y = int.Parse(Console.ReadLine());
           
            int z = x / y;
            Console.WriteLine("The result is:" + z);
            Console.WriteLine("Ënd of the program");
            Console.WriteLine("--------------------------------------");
            try
            {
                Console.Write("Ënter 1st number:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ënter 2nd number:");
                int b = int.Parse(Console.ReadLine());
              
                int c = a / b;
                Console.WriteLine("The result is:" + c);

            }
            catch (DivideByZeroException ex1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Attempted to divided by zero");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            catch (FormatException ex2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input must be numaric");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ex.Message");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
                Console.WriteLine("Ënd of the program");

            }

       } 
    
    }
}
