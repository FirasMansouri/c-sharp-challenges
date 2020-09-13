using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int infini = 0;
            do
            {
                string aStr = "";
                int a = 0, b = 0, counter = 0; ;

                do
                {
                    Console.WriteLine("Enter an integer > 0: ");
                    aStr = Console.ReadLine();
                    a = int.Parse(aStr);
                } while (a <= 0);

                b = a;
                do
                {
                    counter = 0;
                    for (int i = 1; i <= a; i++)
                    {
                        if (a % i == 0) counter++;
                    }
                    a++;
                } while (counter > 2);
                a--;
                Console.WriteLine("NextPrime( " + b + " )--> " + a);
                Console.ReadLine();
            } while (infini == 0);
            
        }
    }
}
