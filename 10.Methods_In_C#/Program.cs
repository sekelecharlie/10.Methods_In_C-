using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Your name");

            // string name = Console.ReadLine();
            //Console.WriteLine("Hi " + name);
            sayHi();
            AddNumbers();
            Console.ReadLine ();



        }
        static void sayHi()
        {
            Console.WriteLine("Yourname");
           string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
          

        }
        static void AddNumbers()
        {
            Console.WriteLine("Enter first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of your numbers is " + (num1 + num2));



         }

    }
}
