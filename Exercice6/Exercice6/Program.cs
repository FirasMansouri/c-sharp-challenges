using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        public static string MysteryFunc(string str) 
        {
            string newWord = "";
            double szam = char.GetNumericValue(str[0]);
            if(szam<0)
            {
                newWord+=str[0];
            }
            for (int i = 1; i < str.Length; i++)
            { 
                szam = char.GetNumericValue(str[i]);
                if(szam>0)
                {
                    for (int j = 0; j < szam-1; j++)
                    {
                        newWord += str[i-1];
                    }
                }
                else
                {
                    newWord+=str[i];
                }
            
            }
            return newWord;			
        }

        static void Main()
        {
            //----------------------testing-------------------
            Console.WriteLine("A4B5C2 ---> " + MysteryFunc("A4B5C2") );
            Console.WriteLine("C2F1E5 ---> " + MysteryFunc("C2F1E5") );
            Console.WriteLine("T4S2V2 ---> " + MysteryFunc("T4S2V2") );
            Console.WriteLine("A1B2C3D4 ---> " + MysteryFunc("A1B2C3D4") );
            Console.ReadLine();       
        }
    }
}
