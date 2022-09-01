using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseBurgerJustToEat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast inn Temperatur");
            int grader = Convert.ToInt32(Console.ReadLine());

            if (grader > 0)

            {

                Console.WriteLine("PlusGrader");
            }

            else if (grader == 0)

            {
                Console.WriteLine("Null Grader");
            }

            else

            {

                Console.WriteLine("MinusGrader");
            }

        }
    }
}
