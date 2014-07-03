using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Maththing
    {
        public int larger;

        public int Compare(int x, int y)
        {
            int result;
            if (x > y)
                larger = y;
            else
                larger = x;
            return result=larger;

        }


    class Program
    {
        static void Main(string[] args)
        {
            
           // int abc = 500;
           // int xyz = 200;

           Console.WriteLine("Enter first number: ");
           int abc = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter second number: ");
           int xyz = int.Parse(Console.ReadLine());

            // int.Parse(Console.ReadLine());
           Maththing math = new Maththing();
           var Blah = math.Compare(abc, xyz);
        
            Console.WriteLine("The smallest is: " + Blah);
            Console.ReadLine();

        }

    }

    


            
    }

}


