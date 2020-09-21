using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7
{
    class Program
    {
        public static int SockPairs(string socks)
        {
            int result = 0;
            for (int i = 0; i < socks.Length && socks[i] != '*'; i++)
            {
                int count = socks.Count(f => f == socks[i]);
                result += count / 2;
                socks = socks.Replace(socks[i].ToString(), "*");
            }
            return result;
        }
        static void Main(string[] args)
        {
            //---------------------testing----------------------
            Console.WriteLine("testing:");
            Console.WriteLine("---------");
            Console.WriteLine("SockPairs(AA) ---> " + SockPairs("AA"));
            Console.WriteLine("SockPairs(ABABC) ---> " + SockPairs("ABABC"));
            Console.WriteLine("SockPairs(CABBACCC) ---> " + SockPairs("CABBACCC"));
            Console.ReadLine();
        }
    }
}
