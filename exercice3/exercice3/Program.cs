using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nStr, aStr, bStr;
            int n, a, b;
            List<double> rangeList=new List<double>();
            do
            {
                Console.WriteLine("enter 3 integer ");
                Console.Write("n: ");
                nStr= Console.ReadLine();
                Console.Write("a: ");
                aStr= Console.ReadLine();
                Console.Write("b: ");
                bStr= Console.ReadLine();
                n= int.Parse(nStr);
                a= int.Parse(aStr);
                b= int.Parse(bStr);
            }while( a > b );

            double nDouble = Convert.ToDouble(n);
            double k= 1/nDouble;

            for(int i=a; i<b; i++ )
            {
                double result=Math.Pow(i , k);
                if(result % 1 == 0 )
                {
                    rangeList.Add(result);
                }                
            }
            
            Console.Write("Ranger( " + n + " , " + a + " , " + b + " )--->" );
            foreach(double range in rangeList)
            {
                Console.Write(range);
                Console.Write(" | ");
            }
            Console.ReadLine();
        }
    }
}
