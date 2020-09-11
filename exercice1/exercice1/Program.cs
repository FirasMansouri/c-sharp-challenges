using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumber = "";
            int number;
            do
            {
                Console.Write("enter a positive number: ");
                strNumber = Console.ReadLine();
                number = Int32.Parse(strNumber);
            } while (number <= 0);

            string reverseStrNumber = "";
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                reverseStrNumber = reverseStrNumber + strNumber[i];
            }

            Console.WriteLine("ReverseAndNot( " + strNumber + ")--->" + reverseStrNumber + strNumber);
            Console.ReadLine();
        }
    }
}
