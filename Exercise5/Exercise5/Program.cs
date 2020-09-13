using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int infini=0;
            string sentence="";
            Regex rx=new Regex("^#[a-fA-F0-9]{6}$");
            do
            {
                Console.WriteLine("Enter a sentence: ");
                sentence= Console.ReadLine();
                MatchCollection matches = rx.Matches(sentence);

                if(matches.Count==1)
                {
                    Console.WriteLine("isValidHexCode( " + sentence + " ) ---> true");
                }
                else
                {
                    Console.WriteLine("isValidHexCode( " + sentence + " ) ---> false");
                }
                Console.ReadLine();
            }while(infini==0);
           
        }
    }
}
