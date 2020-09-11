using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            do
            {
                string sentence = "";
                do
                {
                    Console.Write("Enter a sentence: ");
                    sentence = Console.ReadLine();
                } while (sentence == "" || sentence.Trim().Split(' ').Length<=1);
                sentence = sentence.Trim();
                string[] sentenceWords = sentence.Split(' ');
                int numberOfWords = sentenceWords.Length;
                string result = "smooth sentence";
                
                for (int i = 0, j = 1; j < numberOfWords; i++, j++)
                {
                    if (sentenceWords[i].Last() != sentenceWords[j].First())
                    {
                        result = "Not smooth sentence";
                        break;
                    }
                }
                Console.WriteLine("result --->  " + result);
                
                
            } while (k==0);
            
        }
    }
}
